namespace LoginForm.ServiceForms
{
    partial class robotControlUI
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
            this.upBtn = new ReaLTaiizor.HopeSimpleButton();
            this.downBtn = new ReaLTaiizor.HopeSimpleButton();
            this.homeBtn = new ReaLTaiizor.HopeSimpleButton();
            this.extendBtn = new ReaLTaiizor.HopeSimpleButton();
            this.retractBtn = new ReaLTaiizor.HopeSimpleButton();
            this.moveBtn = new ReaLTaiizor.HopeSimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skyComboBox1 = new ReaLTaiizor.SkyComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // upBtn
            // 
            this.upBtn.ButtonType = ReaLTaiizor.HopeButtonType.Primary;
            this.upBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.upBtn.Location = new System.Drawing.Point(249, 35);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(150, 40);
            this.upBtn.TabIndex = 2;
            this.upBtn.Text = "Up";
            this.upBtn.TextColor = System.Drawing.Color.White;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.ButtonType = ReaLTaiizor.HopeButtonType.Primary;
            this.downBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.downBtn.Location = new System.Drawing.Point(249, 202);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(150, 40);
            this.downBtn.TabIndex = 3;
            this.downBtn.Text = "Down";
            this.downBtn.TextColor = System.Drawing.Color.White;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.ButtonType = ReaLTaiizor.HopeButtonType.Primary;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.homeBtn.Location = new System.Drawing.Point(249, 119);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(150, 40);
            this.homeBtn.TabIndex = 4;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextColor = System.Drawing.Color.White;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // extendBtn
            // 
            this.extendBtn.ButtonType = ReaLTaiizor.HopeButtonType.Primary;
            this.extendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.extendBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.extendBtn.Location = new System.Drawing.Point(67, 119);
            this.extendBtn.Name = "extendBtn";
            this.extendBtn.Size = new System.Drawing.Size(150, 40);
            this.extendBtn.TabIndex = 5;
            this.extendBtn.Text = "Extend";
            this.extendBtn.TextColor = System.Drawing.Color.White;
            this.extendBtn.Click += new System.EventHandler(this.extendBtn_Click);
            // 
            // retractBtn
            // 
            this.retractBtn.ButtonType = ReaLTaiizor.HopeButtonType.Primary;
            this.retractBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retractBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.retractBtn.Location = new System.Drawing.Point(430, 119);
            this.retractBtn.Name = "retractBtn";
            this.retractBtn.Size = new System.Drawing.Size(150, 40);
            this.retractBtn.TabIndex = 6;
            this.retractBtn.Text = "Retract";
            this.retractBtn.TextColor = System.Drawing.Color.White;
            this.retractBtn.Click += new System.EventHandler(this.retractBtn_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.ButtonType = ReaLTaiizor.HopeButtonType.Primary;
            this.moveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.moveBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.moveBtn.Location = new System.Drawing.Point(127, 0);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(197, 24);
            this.moveBtn.TabIndex = 2;
            this.moveBtn.Text = "Move Station";
            this.moveBtn.TextColor = System.Drawing.Color.White;
            this.moveBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.skyComboBox1);
            this.panel1.Controls.Add(this.moveBtn);
            this.panel1.Location = new System.Drawing.Point(145, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 24);
            this.panel1.TabIndex = 7;
            // 
            // skyComboBox1
            // 
            this.skyComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.skyComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skyComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skyComboBox1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyComboBox1.FormattingEnabled = true;
            this.skyComboBox1.ItemHeight = 16;
            this.skyComboBox1.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.skyComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.skyComboBox1.Location = new System.Drawing.Point(0, 0);
            this.skyComboBox1.Name = "skyComboBox1";
            this.skyComboBox1.Size = new System.Drawing.Size(127, 22);
            this.skyComboBox1.StartIndex = 0;
            this.skyComboBox1.TabIndex = 4;
            // 
            // robotControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.retractBtn);
            this.Controls.Add(this.extendBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "robotControlUI";
            this.Size = new System.Drawing.Size(913, 578);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.HopeSimpleButton upBtn;
        private ReaLTaiizor.HopeSimpleButton downBtn;
        private ReaLTaiizor.HopeSimpleButton homeBtn;
        private ReaLTaiizor.HopeSimpleButton extendBtn;
        private ReaLTaiizor.HopeSimpleButton retractBtn;
        private ReaLTaiizor.HopeSimpleButton moveBtn;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.SkyComboBox skyComboBox1;
    }
}
