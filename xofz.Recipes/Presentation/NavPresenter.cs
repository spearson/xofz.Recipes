namespace xofz.Recipes.Presentation
{
    using System.Threading;
    using xofz.Framework;
    using xofz.Presentation;
    using xofz.Recipes.UI;
    using xofz.UI;

    public sealed class NavPresenter : Presenter
    {
        public NavPresenter(
            NavUi ui, 
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

            this.ui.RecipesKeyTapped += this.ui_RecipesKeyTapped;
            this.ui.AddKeyTapped += this.ui_AddKeyTapped;
            this.ui.LogKeyTapped += this.ui_LogKeyTapped;
            this.ui.CloseKeyTapped += this.ui_CloseKeyTapped;

            this.web.Run<Navigator>(n => n.RegisterPresenter(this));
        }

        private void ui_RecipesKeyTapped()
        {
            this.web.Run<Navigator>(n => n.Present<RecipesPresenter>());
        }

        private void ui_AddKeyTapped()
        {
            this.web.Run<Navigator>(n => n.Present<AddUpdatePresenter>());
        }

        private void ui_LogKeyTapped()
        {
            this.web.Run<Navigator>(n => n.Present<LogPresenter>());
        }

        private void ui_CloseKeyTapped()
        {
            this.web.Run<Navigator>(n => n.Present<ShutdownPresenter>());
        }

        private int setupIf1;
        private readonly NavUi ui;
        private readonly MethodWeb web;
    }
}
