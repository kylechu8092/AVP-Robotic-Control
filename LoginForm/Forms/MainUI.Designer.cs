using FontAwesome;
using ReaLTaiizor;
namespace LoginForm.Forms
{
    partial class MainUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.controlBox1 = new ReaLTaiizor.ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuhamBtn = new System.Windows.Forms.PictureBox();
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.armControlBtn = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.siderbarTransition = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuhamBtn)).BeginInit();
            this.sidebarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::LoginForm.Properties.Resources.icons8_packet_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 91);
            this.button1.TabIndex = 3;
            this.button1.Text = "           Packet Capture";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::LoginForm.Properties.Resources.icons8_terminal_30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 91);
            this.button2.TabIndex = 4;
            this.button2.Text = "           Serial Terminal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::LoginForm.Properties.Resources.icons8_settings_32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 91);
            this.button4.TabIndex = 6;
            this.button4.Text = "           Settings";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.controlBox1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.menuhamBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1093, 36);
            this.topPanel.TabIndex = 2;
            // 
            // controlBox1
            // 
            this.controlBox1.BackColor = System.Drawing.Color.White;
            this.controlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBox1.DefaultLocation = false;
            this.controlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBox1.EnableHoverHighlight = true;
            this.controlBox1.EnableMaximizeButton = true;
            this.controlBox1.EnableMinimizeButton = true;
            this.controlBox1.ForeColor = System.Drawing.Color.Black;
            this.controlBox1.Location = new System.Drawing.Point(1003, 0);
            this.controlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.controlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(90, 25);
            this.controlBox1.TabIndex = 2;
            this.controlBox1.Text = "controlBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "AVP TECHNOLOGY LLC";
            // 
            // menuhamBtn
            // 
            this.menuhamBtn.Image = global::LoginForm.Properties.Resources.icons8_hamburger_30;
            this.menuhamBtn.Location = new System.Drawing.Point(12, 5);
            this.menuhamBtn.Name = "menuhamBtn";
            this.menuhamBtn.Size = new System.Drawing.Size(46, 26);
            this.menuhamBtn.TabIndex = 0;
            this.menuhamBtn.TabStop = false;
            this.menuhamBtn.Click += new System.EventHandler(this.menuhamBtn_Click);
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.sidebarContainer.Controls.Add(this.armControlBtn);
            this.sidebarContainer.Controls.Add(this.button1);
            this.sidebarContainer.Controls.Add(this.button2);
            this.sidebarContainer.Controls.Add(this.button4);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 36);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(180, 578);
            this.sidebarContainer.TabIndex = 7;
            this.sidebarContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarContainer_Paint);
            // 
            // armControlBtn
            // 
            this.armControlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.armControlBtn.FlatAppearance.BorderSize = 0;
            this.armControlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.armControlBtn.Image = global::LoginForm.Properties.Resources.icons8_robot_arm_32;
            this.armControlBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.armControlBtn.Location = new System.Drawing.Point(3, 3);
            this.armControlBtn.Name = "armControlBtn";
            this.armControlBtn.Size = new System.Drawing.Size(192, 91);
            this.armControlBtn.TabIndex = 7;
            this.armControlBtn.Text = "           Arm Control";
            this.armControlBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.armControlBtn.UseVisualStyleBackColor = false;
            this.armControlBtn.Click += new System.EventHandler(this.armControlBtn_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // siderbarTransition
            // 
            this.siderbarTransition.Interval = 15;
            this.siderbarTransition.Tick += new System.EventHandler(this.siderbarTransition_Tick);
            // 
            // MainUI
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1093, 614);
            this.Controls.Add(this.sidebarContainer);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuhamBtn)).EndInit();
            this.sidebarContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox menuhamBtn;
        private System.Windows.Forms.Label label1;
        private ControlBox controlBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer siderbarTransition;
        private System.Windows.Forms.Button armControlBtn;
    }
}
