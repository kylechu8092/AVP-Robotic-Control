namespace LoginForm.ServiceForms
{
    partial class SettingsUI
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
            this.displayPanelUser = new System.Windows.Forms.FlowLayoutPanel();
            this.addUserPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // displayPanelUser
            // 
            this.displayPanelUser.AutoScroll = true;
            this.displayPanelUser.AutoScrollMargin = new System.Drawing.Size(0, 200);
            this.displayPanelUser.AutoSize = true;
            this.displayPanelUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.displayPanelUser.Location = new System.Drawing.Point(0, 548);
            this.displayPanelUser.Name = "displayPanelUser";
            this.displayPanelUser.Size = new System.Drawing.Size(913, 0);
            this.displayPanelUser.TabIndex = 1;
            // 
            // addUserPanel
            // 
            this.addUserPanel.AutoSize = true;
            this.addUserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserPanel.Location = new System.Drawing.Point(0, 0);
            this.addUserPanel.Name = "addUserPanel";
            this.addUserPanel.Size = new System.Drawing.Size(913, 0);
            this.addUserPanel.TabIndex = 2;
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.addUserPanel);
            this.Controls.Add(this.displayPanelUser);
            this.Name = "SettingsUI";
            this.Size = new System.Drawing.Size(913, 548);
            this.Load += new System.EventHandler(this.SettingsUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel displayPanelUser;
        private System.Windows.Forms.Panel addUserPanel;
    }
}
