namespace xofz.Recipes.UI.Forms
{
    partial class UserControlAddUpdateUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.ingredientsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.directionsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resetKey = new System.Windows.Forms.Button();
            this.addUpdateKey = new System.Windows.Forms.Button();
            this.lookupKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add or Update a Recipe";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(133, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(352, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recipe Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(133, 93);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(604, 22);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // ingredientsTextBox
            // 
            this.ingredientsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsTextBox.Location = new System.Drawing.Point(133, 121);
            this.ingredientsTextBox.Multiline = true;
            this.ingredientsTextBox.Name = "ingredientsTextBox";
            this.ingredientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ingredientsTextBox.Size = new System.Drawing.Size(604, 179);
            this.ingredientsTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingredients:";
            // 
            // directionsTextBox
            // 
            this.directionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionsTextBox.Location = new System.Drawing.Point(133, 306);
            this.directionsTextBox.Multiline = true;
            this.directionsTextBox.Name = "directionsTextBox";
            this.directionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.directionsTextBox.Size = new System.Drawing.Size(604, 205);
            this.directionsTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Directions:";
            // 
            // resetKey
            // 
            this.resetKey.AutoSize = true;
            this.resetKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.resetKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.resetKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetKey.Location = new System.Drawing.Point(743, 306);
            this.resetKey.Name = "resetKey";
            this.resetKey.Size = new System.Drawing.Size(69, 32);
            this.resetKey.TabIndex = 9;
            this.resetKey.Text = "Reset";
            this.resetKey.UseVisualStyleBackColor = true;
            this.resetKey.Click += new System.EventHandler(this.resetKey_Click);
            // 
            // addUpdateKey
            // 
            this.addUpdateKey.AutoSize = true;
            this.addUpdateKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addUpdateKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.addUpdateKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addUpdateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUpdateKey.Location = new System.Drawing.Point(743, 479);
            this.addUpdateKey.Name = "addUpdateKey";
            this.addUpdateKey.Size = new System.Drawing.Size(138, 32);
            this.addUpdateKey.TabIndex = 10;
            this.addUpdateKey.Text = "Add or Update";
            this.addUpdateKey.UseVisualStyleBackColor = true;
            this.addUpdateKey.Click += new System.EventHandler(this.addUpdateKey_Click);
            // 
            // lookupKey
            // 
            this.lookupKey.AutoSize = true;
            this.lookupKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lookupKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.lookupKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lookupKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lookupKey.Location = new System.Drawing.Point(491, 55);
            this.lookupKey.Name = "lookupKey";
            this.lookupKey.Size = new System.Drawing.Size(80, 32);
            this.lookupKey.TabIndex = 11;
            this.lookupKey.Text = "Lookup";
            this.lookupKey.UseVisualStyleBackColor = true;
            this.lookupKey.Click += new System.EventHandler(this.lookupKey_Click);
            // 
            // UserControlAddUpdateUi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lookupKey);
            this.Controls.Add(this.addUpdateKey);
            this.Controls.Add(this.resetKey);
            this.Controls.Add(this.directionsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ingredientsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlAddUpdateUi";
            this.Size = new System.Drawing.Size(884, 511);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox ingredientsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox directionsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resetKey;
        private System.Windows.Forms.Button addUpdateKey;
        private System.Windows.Forms.Button lookupKey;
    }
}
