namespace xofz.Recipes.Root.Commands
{
    using xofz.Framework;
    using xofz.Recipes.Framework;
    using xofz.Recipes.Presentation;
    using xofz.Recipes.UI;
    using xofz.Root;
    using xofz.UI;

    public class SetupAddUpdateCommand : Command
    {
        public SetupAddUpdateCommand(
            AddUpdateUi ui,
            ShellUi shell,
            MethodWeb web)
        {
            this.ui = ui;
            this.shell = shell;
            this.web = web;
        }

        public override void Execute()
        {
            this.registerDependencies();
            new AddUpdatePresenter(
                    this.ui,
                    this.shell,
                    this.web)
                .Setup();
        }

        private void registerDependencies()
        {
            var w = this.web;
            w.RegisterDependency(
                new RecipeManager(@"Recipes"));
        }

        private readonly AddUpdateUi ui;
        private readonly ShellUi shell;
        private readonly MethodWeb web;
    }
}