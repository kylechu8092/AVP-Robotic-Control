namespace LoginForm.ServiceForms
{
    partial class Dashboard
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timeRichTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(87, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(451, 93);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // timeRichTxt
            // 
            this.timeRichTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timeRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeRichTxt.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRichTxt.Location = new System.Drawing.Point(87, 195);
            this.timeRichTxt.Name = "timeRichTxt";
            this.timeRichTxt.ReadOnly = true;
            this.timeRichTxt.Size = new System.Drawing.Size(451, 93);
            this.timeRichTxt.TabIndex = 2;
            this.timeRichTxt.Text = "";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.timeRichTxt);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(913, 578);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox timeRichTxt;
    }
}
