﻿namespace xofz.Recipes.UI.Forms
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using xofz.UI.Forms;

    public partial class UserControlRecipesUi : UserControlUi, RecipesUi
    {
        public UserControlRecipesUi(
            Func<IEnumerable<string>, MaterializedEnumerable<string>> materializeStrings,
            Func<IEnumerable<Recipe>, MaterializedEnumerable<Recipe>> materializeRecipes)
        {
            this.materializeStrings = materializeStrings;
            this.materializeRecipes = materializeRecipes;
            this.InitializeComponent();
        }

        public event Action SearchTextChanged;

        public event Action ClearSearchKeyTapped;

        public event Action<string> OpenRequested;

        public event Action<string> DeleteRequested;
        
        string RecipesUi.NameSearchText
        {
            get { return this.nameSearchTextBox.Text; }

            set { this.nameSearchTextBox.Text = value; }
        }

        string RecipesUi.DescriptionSearchText
        {
            get { return this.descriptionSearchTextBox.Text; }

            set { this.descriptionSearchTextBox.Text = value; }
        }

        MaterializedEnumerable<string> RecipesUi.IngredientsSearchText
        {
            get { return this.materializeStrings(this.ingredientsSearchTextBox.Lines); }

            set { this.ingredientsSearchTextBox.Lines = value?.ToArray(); }
        }

        MaterializedEnumerable<string> RecipesUi.DirectionsSearchText
        {
            get { return this.materializeStrings(this.directionsSearchTextBox.Lines); }

            set { this.directionsSearchTextBox.Lines = value?.ToArray(); }
        }

        MaterializedEnumerable<Recipe> RecipesUi.MatchingRecipes
        {
            get
            {
                var ll = new LinkedList<Recipe>();
                foreach (DataGridViewRow row in this.recipesGrid.Rows)
                {
                    ll.AddLast(
                        new Recipe
                        {
                            Name = row.Cells[0].ToString(),
                            Description = row.Cells[1].ToString(),
                            Directions = this.materializeStrings(
                                row.Cells[2].ToString().Split(
                                    new[] { Environment.NewLine },
                                    StringSplitOptions.RemoveEmptyEntries))
                        });
                }

                return this.materializeRecipes(ll);
            }

            set
            {
                this.recipesGrid.Rows.Clear();
                foreach (var recipe in value)
                {
                    this.recipesGrid.Rows.Add(
                        recipe.Name,
                        recipe.Description);
                }
            }
        }

        private void clearSearchKey_Click(object sender, EventArgs e)
        {
            new Thread(() => this.ClearSearchKeyTapped?.Invoke()).Start();
        }

        private void nameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            new Thread(() => this.SearchTextChanged?.Invoke()).Start();
        }

        private void descriptionSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            new Thread(() => this.SearchTextChanged?.Invoke()).Start();
        }

        private void ingredientsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            new Thread(() => this.SearchTextChanged?.Invoke()).Start();
        }

        private void directionsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            new Thread(() => this.SearchTextChanged?.Invoke()).Start();
        }

        private void recipesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rg = this.recipesGrid;
            if (rg.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.RowIndex >= 0)
            {
                var row = rg.Rows[e.RowIndex];
                var recipeName = row.Cells[0].Value?.ToString();
                if (string.IsNullOrWhiteSpace(recipeName))
                {
                    return;
                }

                var buttonType = rg.Columns[e.ColumnIndex].HeaderText;
                if (buttonType == "Open")
                {
                    new Thread(() => this.OpenRequested?.Invoke(recipeName)).Start();
                }
                else
                {
                    new Thread(() => this.DeleteRequested?.Invoke(recipeName)).Start();
                }
                
            }
        }

        private readonly Func<IEnumerable<string>, MaterializedEnumerable<string>> materializeStrings;
        private readonly Func<IEnumerable<Recipe>, MaterializedEnumerable<Recipe>> materializeRecipes;
    }
}
