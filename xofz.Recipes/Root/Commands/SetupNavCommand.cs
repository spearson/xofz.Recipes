namespace xofz.Recipes.Root.Commands
{
    using xofz.Framework;
    using xofz.Recipes.Presentation;
    using xofz.Recipes.UI;
    using xofz.Root;
    using xofz.UI;

    public class SetupNavCommand : Command
    {
        public SetupNavCommand(
            NavUi ui, 
            ShellUi shell,
            MethodWeb web)
        {
            this.ui = ui;
            this.shell = shell;
            this.web = web;
        }

        public override void Execute()
        {
            new NavPresenter(
                this.ui, 
                this.shell, 
                this.web)
                .Setup();
        }

        private readonly NavUi ui;
        private readonly ShellUi shell;
        private readonly MethodWeb web;
    }
}
