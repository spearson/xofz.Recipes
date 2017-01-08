namespace xofz.Recipes.UI
{
    using System;
    using xofz.UI;

    public interface AddUpdateUi : Ui
    {
        event Action AddUpdateKeyTapped;

        event Action ResetKeyTapped;

        Recipe RecipeToAddUpdate { get; set; }
    }
}
