﻿namespace LoginForm.ServiceForms
{
    partial class AddUserForm
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
            this.addBtn = new ReaLTaiizor.SkyButton();
            this.Role = new ReaLTaiizor.SkyTextBox();
            this.usernameTxt = new ReaLTaiizor.SkyTextBox();
            this.idTxt = new ReaLTaiizor.SkyTextBox();
            this.isActiveTxt = new ReaLTaiizor.SkyTextBox();
            this.passwordTxt = new ReaLTaiizor.SkyTextBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.addBtn.Location = new System.Drawing.Point(376, 24);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Role.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.Role.Location = new System.Drawing.Point(286, 24);
            this.Role.MaxLength = 32767;
            this.Role.MultiLine = false;
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(75, 21);
            this.Role.TabIndex = 17;
            this.Role.Text = "Role";
            this.Role.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Role.UseSystemPasswordChar = false;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.usernameTxt.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.usernameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.usernameTxt.Location = new System.Drawing.Point(62, 24);
            this.usernameTxt.MaxLength = 32767;
            this.usernameTxt.MultiLine = false;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(75, 21);
            this.usernameTxt.TabIndex = 13;
            this.usernameTxt.Text = "Username";
            this.usernameTxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTxt.UseSystemPasswordChar = false;
            // 
            // idTxt
            // 
            this.idTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.idTxt.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.idTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.idTxt.Location = new System.Drawing.Point(20, 24);
            this.idTxt.MaxLength = 32767;
            this.idTxt.MultiLine = false;
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(36, 21);
            this.idTxt.TabIndex = 14;
            this.idTxt.Text = "ID";
            this.idTxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.idTxt.UseSystemPasswordChar = false;
            // 
            // isActiveTxt
            // 
            this.isActiveTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.isActiveTxt.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.isActiveTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.isActiveTxt.Location = new System.Drawing.Point(224, 24);
            this.isActiveTxt.MaxLength = 32767;
            this.isActiveTxt.MultiLine = false;
            this.isActiveTxt.Name = "isActiveTxt";
            this.isActiveTxt.Size = new System.Drawing.Size(56, 21);
            this.isActiveTxt.TabIndex = 15;
            this.isActiveTxt.Text = "isActive";
            this.isActiveTxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.isActiveTxt.UseSystemPasswordChar = false;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.passwordTxt.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.passwordTxt.Location = new System.Drawing.Point(143, 24);
            this.passwordTxt.MaxLength = 32767;
            this.passwordTxt.MultiLine = false;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(75, 21);
            this.passwordTxt.TabIndex = 16;
            this.passwordTxt.Text = "Password";
            this.passwordTxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTxt.UseSystemPasswordChar = false;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Role);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.isActiveTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.addBtn);
            this.Name = "AddUserForm";
            this.Size = new System.Drawing.Size(497, 62);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.SkyButton addBtn;
        private ReaLTaiizor.SkyTextBox Role;
        private ReaLTaiizor.SkyTextBox usernameTxt;
        private ReaLTaiizor.SkyTextBox idTxt;
        private ReaLTaiizor.SkyTextBox isActiveTxt;
        private ReaLTaiizor.SkyTextBox passwordTxt;
    }
}
