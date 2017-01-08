namespace xofz.Recipes.Presentation
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using xofz.Framework;
    using xofz.Framework.Materialization;
    using xofz.Presentation;
    using xofz.Recipes.Framework;
    using xofz.Recipes.UI;
    using xofz.UI;

    public sealed class RecipesPresenter : Presenter
    {
        public RecipesPresenter(
            RecipesUi ui, 
            ShellUi shell,
            MethodWeb web) 
            : base(ui, shell)
        {
            this.ui = ui;
            this.web = web;
        }

        public void Setup()
        {
            if (Interlocked.CompareExchange(ref this.setupIf1, 1, 0) == 1)
            {
                return;
            }

            this.ui.SearchTextChanged += this.ui_SearchTextChanged;
            this.ui.ClearSearchKeyTapped += this.ui_ClearSearchKeyTapped;
            this.web.Run<RecipeLoader>(loader =>
            {
                var recipes = loader.All();
                UiHelpers.Write(this.ui, () => this.ui.MatchingRecipes
                    = new LinkedListMaterializedEnumerable<Recipe>(recipes));
            });

            this.web.Run<Navigator>(n => n.RegisterPresenter(this));
        }

        private void ui_ClearSearchKeyTapped()
        {
            UiHelpers.Write(this.ui, () =>
            {
                this.ui.NameSearchText = null;
                this.ui.DescriptionSearchText = null;
                this.ui.IngredientsSearchText = null;
                this.ui.DirectionsSearchText = null;
            });
        }

        private void ui_SearchTextChanged()
        {
            var w = this.web;
            var nst = UiHelpers.Read(this.ui, () => this.ui.NameSearchText);
            var dest = UiHelpers.Read(this.ui, () => this.ui.DescriptionSearchText);
            var ingst = UiHelpers.Read(this.ui, () => this.ui.IngredientsSearchText);
            var dist = UiHelpers.Read(this.ui, () => this.ui.DirectionsSearchText);


            var matches = w.Run<RecipeLoader, IEnumerable<Recipe>>(loader => loader.All());
            if (!string.IsNullOrWhiteSpace(nst))
            {
                matches = matches.Where(
                    recipe => recipe.Name
                        .ToLower()
                        .Contains(nst.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(dest))
            {
                matches = matches.Where(
                    recipe => recipe.Description
                    .ToLower()
                    .Contains(dest.ToLower()));
            }

            var filledIngredients = ingst.Where(i => !string.IsNullOrWhiteSpace(i)).ToList();
            if (filledIngredients.Any())
            {
                matches = matches.Where(
                    recipe => recipe.Ingredients
                        .All(i => filledIngredients.Any(fi => i.ToLower()
                            .Contains(fi.ToLower()))));
            }

            var filledDirections = dist.Where(d => !string.IsNullOrWhiteSpace(d)).ToList();
            if (filledDirections.Any())
            {
                matches = matches.Where(
                    recipe => recipe.Directions
                        .All(d => filledDirections.Any(fd => d.ToLower()
                            .Contains(fd.ToLower()))));
            }

            UiHelpers.Write(
                this.ui, () => this.ui.MatchingRecipes =
                    new LinkedListMaterializedEnumerable<Recipe>(matches));
        }

        private int setupIf1;
        private readonly RecipesUi ui;
        private readonly MethodWeb web;
    }
}
