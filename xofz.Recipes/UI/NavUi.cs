namespace xofz.Recipes.UI
{
    using System;
    using xofz.UI;

    public interface NavUi : Ui
    {
        event Action RecipesKeyTapped;

        event Action AddKeyTapped;

        event Action LogKeyTapped;

        event Action CloseKeyTapped;
    }
}
