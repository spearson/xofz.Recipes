namespace xofz.Recipes.UI
{
    using System;
    using xofz.UI;

    public interface RecipesUi : Ui
    {
        event Action SearchTextChanged;

        event Action ClearSearchKeyTapped;

        string NameSearchText { get; set; }

        string DescriptionSearchText { get; set; }

        MaterializedEnumerable<string> IngredientsSearchText { get; set; }

        MaterializedEnumerable<string> DirectionsSearchText { get; set; }

        MaterializedEnumerable<Recipe> MatchingRecipes { get; set; }
    }
}
