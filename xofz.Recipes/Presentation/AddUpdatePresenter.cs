namespace xofz.Recipes.Presentation
{
    using System;
    using System.Threading;
    using xofz.Framework;
    using xofz.Presentation;
    using xofz.Recipes.Framework;
    using xofz.Recipes.UI;
    using xofz.UI;

    public sealed class AddUpdatePresenter : Presenter
    {
        public AddUpdatePresenter(
            AddUpdateUi ui, 
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

            this.ui.AddUpdateKeyTapped += this.ui_AddUpdateKeyTapped;
            this.ui.ResetKeyTapped += this.ui_ResetKeyTapped;

            this.web.Run<Navigator>(n => n.RegisterPresenter(this));
        }

        private void ui_AddUpdateKeyTapped()
        {
            var w = this.web;
            var recipe = UiHelpers.Read(this.ui, () => this.ui.RecipeToAddUpdate);
            if (string.IsNullOrWhiteSpace(recipe.Name))
            {
                w.Run<Messenger>(
                    m => UiHelpers.Write(
                        m.Subscriber,
                        () => m.GiveError("Please enter a recipe name.")));
                return;
            }

            try
            {
                w.Run<RecipeSaver>(saver => saver.Save(recipe));
            }
            catch (ArgumentException)
            {
                w.Run<Messenger>(m =>
                    UiHelpers.Write(
                        m.Subscriber,
                        () => m.GiveError("Please enter a valid file name for the recipe name.")));
            }
        }

        private void ui_ResetKeyTapped()
        {
            var w = this.web;
            var response = Response.No;
            w.Run<Messenger>(m =>
            {
                UiHelpers.Write(
                    m.Subscriber,
                    () => response = m.Question("Really clear all fields?"));
                m.Subscriber.WriteFinished.WaitOne();
            });

            if (response == Response.Yes)
            {
                UiHelpers.Write(this.ui, () => this.ui.RecipeToAddUpdate = new Recipe());
            }
        }

        private int setupIf1;
        private readonly AddUpdateUi ui;
        private readonly MethodWeb web;
    }
}
