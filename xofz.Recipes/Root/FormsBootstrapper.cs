namespace xofz.Recipes.Root
{
    using System.Threading;
    using System.Windows.Forms;
    using xofz.Framework.Materialization;
    using xofz.Presentation;
    using xofz.Recipes.Presentation;
    using xofz.Recipes.Root.Commands;
    using xofz.Recipes.UI.Forms;
    using xofz.Root;
    using xofz.Root.Commands;
    using xofz.UI.Forms;

    public class FormsBootstrapper
    {
        public FormsBootstrapper()
            : this(new CommandExecutor())
        {
        }

        public FormsBootstrapper(CommandExecutor executor)
        {
            this.executor = executor;
        }

        public virtual Form MainForm => this.mainForm;

        public virtual void Bootstrap()
        {
            if (Interlocked.CompareExchange(ref this.bootstrappedIf1, 1, 0) == 1)
            {
                return;
            }

            this.setMainForm(new FormMainUi());
            var mf = this.mainForm;
            var e = this.executor;
            var fm = new FormsMessenger { Subscriber = mf };
            
            e.Execute(new SetupMethodWebCommand(
                fm));
            var w = e.Get<SetupMethodWebCommand>().Web;

            e
                .Execute(new SetupMainCommand(
                    mf,
                    w))
                .Execute(new SetupShutdownCommand(
                    mf, w))
                .Execute(new SetupNavCommand(
                    mf.NavUi,
                    mf,
                    w))
                .Execute(new SetupAddUpdateCommand(
                    new UserControlAddUpdateUi(
                        se => new LinkedListMaterializedEnumerable<string>(se)),
                    mf,
                    w))
                .Execute(new SetupRecipesCommand(
                    new UserControlRecipesUi(
                        s => new LinkedListMaterializedEnumerable<string>(s),
                        r => new LinkedListMaterializedEnumerable<Recipe>(r)),
                    mf,
                    w));

            w.Run<Navigator>(n => n.Present<RecipesPresenter>());
        }

        private void setMainForm(FormMainUi mainForm)
        {
            this.mainForm = mainForm;
        }

        private int bootstrappedIf1;
        private FormMainUi mainForm;
        private readonly CommandExecutor executor;
    }
}
