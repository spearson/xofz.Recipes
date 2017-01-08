namespace xofz.Recipes.UI
{
    using System;
    using xofz.UI;

    public interface NavUi : Ui
    {
        event Action HomeKeyTapped;

        event Action RecipesKeyTapped;

        event Action AddKeyTapped;

        event Action RemoveKeyTapped;

        event Action CloseKeyTapped;
    }
}
