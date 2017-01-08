﻿namespace xofz.Recipes.Root
{
    using System.Threading;
    using System.Windows.Forms;
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
                    w));
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