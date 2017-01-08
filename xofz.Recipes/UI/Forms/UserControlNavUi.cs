namespace xofz.Recipes.UI.Forms
{
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using xofz.UI.Forms;

    public partial class UserControlNavUi : UserControlUi, NavUi
    {
        public UserControlNavUi()
        {
            this.InitializeComponent();
        }

        public event Action HomeKeyTapped;

        public event Action RecipesKeyTapped;

        public event Action AddKeyTapped;

        public event Action RemoveKeyTapped;

        public event Action CloseKeyTapped;

        private void homeKey_Click(object sender, EventArgs e)
        {
            new Thread(() => this.HomeKeyTapped?.Invoke()).Start();
        }

        private void recipesKey_Click(object sender, EventArgs e)
        {
            new Thread(() => this.RecipesKeyTapped?.Invoke()).Start();
        }

        private void addKey_Click(object sender, EventArgs e)
        {
            new Thread(() => this.AddKeyTapped?.Invoke()).Start();
        }

        private void removeKey_Click(object sender, EventArgs e)
        {
            new Thread(() => this.RemoveKeyTapped?.Invoke()).Start();
        }

        private void closeKey_Click(object sender, EventArgs e)
        {
            new Thread(() => this.CloseKeyTapped?.Invoke()).Start();
        }
    }
}
