﻿namespace xofz.Recipes.UI.Forms
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
            this.removeKey = new System.Windows.Forms.Button();
            this.addKey = new System.Windows.Forms.Button();
            this.recipesKey = new System.Windows.Forms.Button();
            this.homeKey = new System.Windows.Forms.Button();
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
            navPanel.Controls.Add(this.closeKey, 5, 0);
            navPanel.Controls.Add(this.removeKey, 3, 0);
            navPanel.Controls.Add(this.addKey, 2, 0);
            navPanel.Controls.Add(this.recipesKey, 1, 0);
            navPanel.Controls.Add(this.homeKey, 0, 0);
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
            this.closeKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.closeKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.closeKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeKey.Location = new System.Drawing.Point(740, 3);
            this.closeKey.Name = "closeKey";
            this.closeKey.Size = new System.Drawing.Size(141, 44);
            this.closeKey.TabIndex = 5;
            this.closeKey.Text = "Close App";
            this.closeKey.UseVisualStyleBackColor = true;
            this.closeKey.Click += new System.EventHandler(this.closeKey_Click);
            // 
            // removeKey
            // 
            this.removeKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.removeKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.removeKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeKey.Location = new System.Drawing.Point(445, 3);
            this.removeKey.Name = "removeKey";
            this.removeKey.Size = new System.Drawing.Size(142, 44);
            this.removeKey.TabIndex = 4;
            this.removeKey.Text = "Remove";
            this.removeKey.UseVisualStyleBackColor = true;
            this.removeKey.Click += new System.EventHandler(this.removeKey_Click);
            // 
            // addKey
            // 
            this.addKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.addKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addKey.Location = new System.Drawing.Point(297, 3);
            this.addKey.Name = "addKey";
            this.addKey.Size = new System.Drawing.Size(142, 44);
            this.addKey.TabIndex = 3;
            this.addKey.Text = "Add";
            this.addKey.UseVisualStyleBackColor = true;
            this.addKey.Click += new System.EventHandler(this.addKey_Click);
            // 
            // recipesKey
            // 
            this.recipesKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recipesKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.recipesKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.recipesKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recipesKey.Location = new System.Drawing.Point(150, 3);
            this.recipesKey.Name = "recipesKey";
            this.recipesKey.Size = new System.Drawing.Size(141, 44);
            this.recipesKey.TabIndex = 2;
            this.recipesKey.Text = "Recipes";
            this.recipesKey.UseVisualStyleBackColor = true;
            this.recipesKey.Click += new System.EventHandler(this.recipesKey_Click);
            // 
            // homeKey
            // 
            this.homeKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.homeKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.homeKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeKey.Location = new System.Drawing.Point(3, 3);
            this.homeKey.Name = "homeKey";
            this.homeKey.Size = new System.Drawing.Size(141, 44);
            this.homeKey.TabIndex = 1;
            this.homeKey.Text = "Home";
            this.homeKey.UseVisualStyleBackColor = true;
            this.homeKey.Click += new System.EventHandler(this.homeKey_Click);
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
        private System.Windows.Forms.Button homeKey;
        private System.Windows.Forms.Button closeKey;
        private System.Windows.Forms.Button removeKey;
    }
}
