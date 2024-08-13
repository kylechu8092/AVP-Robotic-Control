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
            this.skyComboBox1 = new ReaLTaiizor.SkyComboBox();
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
            // skyComboBox1
            // 
            this.skyComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.skyComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skyComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyComboBox1.FormattingEnabled = true;
            this.skyComboBox1.ItemHeight = 16;
            this.skyComboBox1.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.skyComboBox1.Items.AddRange(new object[] {
            "Ethernet Connection",
            "Serial Port Connection"});
            this.skyComboBox1.Location = new System.Drawing.Point(75, 467);
            this.skyComboBox1.Name = "skyComboBox1";
            this.skyComboBox1.Size = new System.Drawing.Size(521, 22);
            this.skyComboBox1.StartIndex = 0;
            this.skyComboBox1.TabIndex = 3;
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
            this.Controls.Add(this.skyComboBox1);
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
        private ReaLTaiizor.SkyComboBox skyComboBox1;
        private ReaLTaiizor.SkyButton skyButton2;
    }
}
