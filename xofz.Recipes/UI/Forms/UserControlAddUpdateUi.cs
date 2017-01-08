namespace xofz.Recipes.UI.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using xofz.UI.Forms;

    public partial class UserControlAddUpdateUi : UserControlUi, AddUpdateUi
    {
        public UserControlAddUpdateUi(
            Func<IEnumerable<string>, 
                MaterializedEnumerable<string>> materializeCollection)
        {
            this.materializeCollection = materializeCollection;
            this.InitializeComponent();
        }

        public event Action AddUpdateKeyTapped;

        public event Action ResetKeyTapped;

        Recipe AddUpdateUi.RecipeToAddUpdate
        {
            get
            {
                return new Recipe
                {
                    Name = this.nameTextBox.Text,
                    Description = this.descriptionTextBox.Text,
                    Ingredients = this.materializeCollection(this.ingredientsTextBox.Lines),
                    Directions = this.materializeCollection(this.directionsTextBox.Lines)
                };
            }

            set
            {
                this.nameTextBox.Text = value?.Name;
                this.descriptionTextBox.Text = value?.Description;
                this.ingredientsTextBox.Lines = value?.Ingredients?.ToArray();
                this.directionsTextBox.Lines = value?.Directions?.ToArray();
            }
        }

        private void resetKey_Click(object sender, EventArgs e)
        {
            new Thread(() => this.ResetKeyTapped?.Invoke()).Start();
        }

        private void addUpdateKey_Click(object sender, EventArgs e)
        {
            new Thread(() => this.AddUpdateKeyTapped?.Invoke()).Start();
        }

        private readonly Func<IEnumerable<string>, 
            MaterializedEnumerable<string>> materializeCollection;
    }
}
