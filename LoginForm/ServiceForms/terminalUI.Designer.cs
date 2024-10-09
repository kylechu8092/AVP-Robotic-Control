namespace LoginForm.ServiceForms
{
    partial class terminalUI
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
            this.displayCmdRichTxt = new System.Windows.Forms.RichTextBox();
            this.cmdTxt = new ReaLTaiizor.SkyTextBox();
            this.skyButton1 = new ReaLTaiizor.SkyButton();
            this.connectionCombo = new ReaLTaiizor.SkyComboBox();
            this.skyButton2 = new ReaLTaiizor.SkyButton();
            this.SuspendLayout();
            // 
            // displayCmdRichTxt
            // 
            this.displayCmdRichTxt.Location = new System.Drawing.Point(85, 21);
            this.displayCmdRichTxt.Name = "displayCmdRichTxt";
            this.displayCmdRichTxt.Size = new System.Drawing.Size(742, 421);
            this.displayCmdRichTxt.TabIndex = 0;
            this.displayCmdRichTxt.Text = "";
            // 
            // cmdTxt
            // 
            this.cmdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.cmdTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.cmdTxt.Location = new System.Drawing.Point(75, 514);
            this.cmdTxt.MaxLength = 32767;
            this.cmdTxt.MultiLine = false;
            this.cmdTxt.Name = "cmdTxt";
            this.cmdTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdTxt.Size = new System.Drawing.Size(661, 32);
            this.cmdTxt.TabIndex = 1;
            this.cmdTxt.Text = "Enter a command";
            this.cmdTxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmdTxt.UseSystemPasswordChar = false;
            this.cmdTxt.Click += new System.EventHandler(this.cmdTxt_Click);
            this.cmdTxt.Enter += new System.EventHandler(this.cmdTxt_Enter);
            this.cmdTxt.Leave += new System.EventHandler(this.cmdTxt_Leave);
            // 
            // skyButton1
            // 
            this.skyButton1.BackColor = System.Drawing.Color.Transparent;
            this.skyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyButton1.Location = new System.Drawing.Point(752, 514);
            this.skyButton1.Name = "skyButton1";
            this.skyButton1.Size = new System.Drawing.Size(75, 23);
            this.skyButton1.TabIndex = 2;
            this.skyButton1.Text = "Send";
            this.skyButton1.Click += new System.EventHandler(this.skyButton1_Click);
            // 
            // connectionCombo
            // 
            this.connectionCombo.BackColor = System.Drawing.Color.Transparent;
            this.connectionCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectionCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.connectionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connectionCombo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.connectionCombo.FormattingEnabled = true;
            this.connectionCombo.ItemHeight = 16;
            this.connectionCombo.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.connectionCombo.Items.AddRange(new object[] {
            "Ethernet Connection",
            "Serial Port Connection"});
            this.connectionCombo.Location = new System.Drawing.Point(75, 467);
            this.connectionCombo.Name = "connectionCombo";
            this.connectionCombo.Size = new System.Drawing.Size(521, 22);
            this.connectionCombo.StartIndex = 0;
            this.connectionCombo.TabIndex = 3;
            // 
            // skyButton2
            // 
            this.skyButton2.BackColor = System.Drawing.Color.Transparent;
            this.skyButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyButton2.Location = new System.Drawing.Point(612, 467);
            this.skyButton2.Name = "skyButton2";
            this.skyButton2.Size = new System.Drawing.Size(215, 23);
            this.skyButton2.TabIndex = 4;
            this.skyButton2.Text = "Set Connection Type";
            this.skyButton2.Click += new System.EventHandler(this.skyButton2_Click);
            // 
            // terminalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.skyButton2);
            this.Controls.Add(this.connectionCombo);
            this.Controls.Add(this.skyButton1);
            this.Controls.Add(this.cmdTxt);
            this.Controls.Add(this.displayCmdRichTxt);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "terminalUI";
            this.Size = new System.Drawing.Size(913, 578);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayCmdRichTxt;
        private ReaLTaiizor.SkyTextBox cmdTxt;
        private ReaLTaiizor.SkyButton skyButton1;
        private ReaLTaiizor.SkyComboBox connectionCombo;
        private ReaLTaiizor.SkyButton skyButton2;
    }
}
