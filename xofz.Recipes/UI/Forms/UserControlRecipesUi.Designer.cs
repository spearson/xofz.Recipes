namespace xofz.Recipes.UI.Forms
{
    partial class UserControlRecipesUi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearSearchKey = new System.Windows.Forms.Button();
            this.directionsSearchTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ingredientsSearchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameSearchTextBox = new System.Windows.Forms.TextBox();
            this.recipesGrid = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngredientsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recipes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearSearchKey);
            this.groupBox1.Controls.Add(this.directionsSearchTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ingredientsSearchTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.descriptionSearchTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameSearchTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 414);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Recipes";
            // 
            // clearSearchKey
            // 
            this.clearSearchKey.AutoSize = true;
            this.clearSearchKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearSearchKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.clearSearchKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clearSearchKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchKey.Location = new System.Drawing.Point(150, 378);
            this.clearSearchKey.Name = "clearSearchKey";
            this.clearSearchKey.Size = new System.Drawing.Size(125, 32);
            this.clearSearchKey.TabIndex = 9;
            this.clearSearchKey.Text = "Clear Search";
            this.clearSearchKey.UseVisualStyleBackColor = true;
            this.clearSearchKey.Click += new System.EventHandler(this.clearSearchKey_Click);
            // 
            // directionsSearchTextBox
            // 
            this.directionsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionsSearchTextBox.Location = new System.Drawing.Point(6, 273);
            this.directionsSearchTextBox.Multiline = true;
            this.directionsSearchTextBox.Name = "directionsSearchTextBox";
            this.directionsSearchTextBox.Size = new System.Drawing.Size(267, 90);
            this.directionsSearchTextBox.TabIndex = 8;
            this.directionsSearchTextBox.TextChanged += new System.EventHandler(this.directionsSearchTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Directions:";
            // 
            // ingredientsSearchTextBox
            // 
            this.ingredientsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsSearchTextBox.Location = new System.Drawing.Point(10, 157);
            this.ingredientsSearchTextBox.Multiline = true;
            this.ingredientsSearchTextBox.Name = "ingredientsSearchTextBox";
            this.ingredientsSearchTextBox.Size = new System.Drawing.Size(263, 90);
            this.ingredientsSearchTextBox.TabIndex = 6;
            this.ingredientsSearchTextBox.TextChanged += new System.EventHandler(this.ingredientsSearchTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingredients:";
            // 
            // descriptionSearchTextBox
            // 
            this.descriptionSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionSearchTextBox.Location = new System.Drawing.Point(10, 105);
            this.descriptionSearchTextBox.Name = "descriptionSearchTextBox";
            this.descriptionSearchTextBox.Size = new System.Drawing.Size(263, 26);
            this.descriptionSearchTextBox.TabIndex = 4;
            this.descriptionSearchTextBox.TextChanged += new System.EventHandler(this.descriptionSearchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description:";
            // 
            // nameSearchTextBox
            // 
            this.nameSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearchTextBox.Location = new System.Drawing.Point(10, 53);
            this.nameSearchTextBox.Name = "nameSearchTextBox";
            this.nameSearchTextBox.Size = new System.Drawing.Size(263, 26);
            this.nameSearchTextBox.TabIndex = 2;
            this.nameSearchTextBox.TextChanged += new System.EventHandler(this.nameSearchTextBox_TextChanged);
            // 
            // recipesGrid
            // 
            this.recipesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.recipesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.descriptionColumn,
            this.IngredientsColumn,
            this.directionsColumn,
            this.deleteColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recipesGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.recipesGrid.Location = new System.Drawing.Point(295, 0);
            this.recipesGrid.Margin = new System.Windows.Forms.Padding(0);
            this.recipesGrid.MultiSelect = false;
            this.recipesGrid.Name = "recipesGrid";
            this.recipesGrid.ReadOnly = true;
            this.recipesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recipesGrid.Size = new System.Drawing.Size(589, 511);
            this.recipesGrid.TabIndex = 4;
            this.recipesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recipesGrid_CellClick);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 250;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.ReadOnly = true;
            this.descriptionColumn.Width = 300;
            // 
            // IngredientsColumn
            // 
            this.IngredientsColumn.HeaderText = "Ingredients";
            this.IngredientsColumn.Name = "IngredientsColumn";
            this.IngredientsColumn.ReadOnly = true;
            this.IngredientsColumn.Width = 300;
            // 
            // directionsColumn
            // 
            this.directionsColumn.HeaderText = "Directions";
            this.directionsColumn.Name = "directionsColumn";
            this.directionsColumn.ReadOnly = true;
            this.directionsColumn.Width = 400;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            // 
            // UserControlRecipesUi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.recipesGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlRecipesUi";
            this.Size = new System.Drawing.Size(884, 511);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox directionsSearchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ingredientsSearchTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameSearchTextBox;
        private System.Windows.Forms.Button clearSearchKey;
        private System.Windows.Forms.DataGridView recipesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionsColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
    }
}
