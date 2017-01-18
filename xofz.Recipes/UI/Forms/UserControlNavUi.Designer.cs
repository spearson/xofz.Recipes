namespace xofz.Recipes.UI.Forms
{
    partial class UserControlNavUi
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
            System.Windows.Forms.TableLayoutPanel navPanel;
            this.closeKey = new System.Windows.Forms.Button();
            this.addKey = new System.Windows.Forms.Button();
            this.recipesKey = new System.Windows.Forms.Button();
            this.logKey = new System.Windows.Forms.Button();
            navPanel = new System.Windows.Forms.TableLayoutPanel();
            navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.ColumnCount = 6;
            navPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            navPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            navPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            navPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            navPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            navPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            navPanel.Controls.Add(this.logKey, 4, 0);
            navPanel.Controls.Add(this.closeKey, 5, 0);
            navPanel.Controls.Add(this.addKey, 1, 0);
            navPanel.Controls.Add(this.recipesKey, 0, 0);
            navPanel.Location = new System.Drawing.Point(0, 0);
            navPanel.Margin = new System.Windows.Forms.Padding(0);
            navPanel.Name = "navPanel";
            navPanel.RowCount = 1;
            navPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            navPanel.Size = new System.Drawing.Size(884, 50);
            navPanel.TabIndex = 0;
            // 
            // closeKey
            // 
            this.closeKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.closeKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.closeKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeKey.Location = new System.Drawing.Point(740, 3);
            this.closeKey.Name = "closeKey";
            this.closeKey.Size = new System.Drawing.Size(141, 44);
            this.closeKey.TabIndex = 5;
            this.closeKey.Text = "Close App";
            this.closeKey.UseVisualStyleBackColor = true;
            this.closeKey.Click += new System.EventHandler(this.closeKey_Click);
            // 
            // addKey
            // 
            this.addKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.addKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addKey.Location = new System.Drawing.Point(150, 3);
            this.addKey.Name = "addKey";
            this.addKey.Size = new System.Drawing.Size(141, 44);
            this.addKey.TabIndex = 3;
            this.addKey.Text = "Add or Update";
            this.addKey.UseVisualStyleBackColor = true;
            this.addKey.Click += new System.EventHandler(this.addKey_Click);
            // 
            // recipesKey
            // 
            this.recipesKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recipesKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.recipesKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.recipesKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recipesKey.Location = new System.Drawing.Point(3, 3);
            this.recipesKey.Name = "recipesKey";
            this.recipesKey.Size = new System.Drawing.Size(141, 44);
            this.recipesKey.TabIndex = 2;
            this.recipesKey.Text = "Recipes";
            this.recipesKey.UseVisualStyleBackColor = true;
            this.recipesKey.Click += new System.EventHandler(this.recipesKey_Click);
            // 
            // logKey
            // 
            this.logKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.logKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.logKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logKey.Location = new System.Drawing.Point(593, 3);
            this.logKey.Name = "logKey";
            this.logKey.Size = new System.Drawing.Size(141, 44);
            this.logKey.TabIndex = 6;
            this.logKey.Text = "Log";
            this.logKey.UseVisualStyleBackColor = true;
            this.logKey.Click += new System.EventHandler(this.logKey_Click);
            // 
            // UserControlNavUi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(navPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlNavUi";
            this.Size = new System.Drawing.Size(884, 50);
            navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addKey;
        private System.Windows.Forms.Button recipesKey;
        private System.Windows.Forms.Button closeKey;
        private System.Windows.Forms.Button logKey;
    }
}
