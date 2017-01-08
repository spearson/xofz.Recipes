namespace xofz.Recipes.UI.Forms
{
    partial class FormMainUi
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screenPanel = new System.Windows.Forms.Panel();
            this.navUi = new xofz.Recipes.UI.Forms.UserControlNavUi();
            this.SuspendLayout();
            // 
            // screenPanel
            // 
            this.screenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.screenPanel.Location = new System.Drawing.Point(0, 50);
            this.screenPanel.Margin = new System.Windows.Forms.Padding(0);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(884, 511);
            this.screenPanel.TabIndex = 0;
            // 
            // navUi
            // 
            this.navUi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navUi.Location = new System.Drawing.Point(0, 0);
            this.navUi.Margin = new System.Windows.Forms.Padding(0);
            this.navUi.Name = "navUi";
            this.navUi.Size = new System.Drawing.Size(884, 50);
            this.navUi.TabIndex = 1;
            // 
            // FormMainUi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.navUi);
            this.Controls.Add(this.screenPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMainUi";
            this.Text = "xofz.Recipes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.this_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screenPanel;
        private UserControlNavUi navUi;
    }
}

