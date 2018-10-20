namespace WinFormUI
{
    partial class CreateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butAddUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butMakePasswordVisible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(12, 47);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(336, 29);
            this.tbUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // butAddUser
            // 
            this.butAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.butAddUser.FlatAppearance.BorderSize = 0;
            this.butAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butAddUser.Location = new System.Drawing.Point(12, 277);
            this.butAddUser.Name = "butAddUser";
            this.butAddUser.Size = new System.Drawing.Size(336, 55);
            this.butAddUser.TabIndex = 12;
            this.butAddUser.Text = "Create";
            this.butAddUser.UseVisualStyleBackColor = false;
            this.butAddUser.Click += new System.EventHandler(this.butAddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 133);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '⦁';
            this.tbPassword.Size = new System.Drawing.Size(336, 29);
            this.tbPassword.TabIndex = 14;
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.Location = new System.Drawing.Point(12, 222);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.PasswordChar = '⦁';
            this.tbPasswordConfirm.Size = new System.Drawing.Size(336, 29);
            this.tbPasswordConfirm.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirm password:";
            // 
            // butMakePasswordVisible
            // 
            this.butMakePasswordVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butMakePasswordVisible.BackgroundImage = global::WinFormUI.Properties.Resources.butMakePasswordVisible;
            this.butMakePasswordVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butMakePasswordVisible.FlatAppearance.BorderSize = 0;
            this.butMakePasswordVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMakePasswordVisible.Location = new System.Drawing.Point(303, 183);
            this.butMakePasswordVisible.Name = "butMakePasswordVisible";
            this.butMakePasswordVisible.Size = new System.Drawing.Size(45, 30);
            this.butMakePasswordVisible.TabIndex = 17;
            this.butMakePasswordVisible.UseVisualStyleBackColor = true;
            this.butMakePasswordVisible.Click += new System.EventHandler(this.butMakePasswordVisible_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(356, 355);
            this.Controls.Add(this.butMakePasswordVisible);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPasswordConfirm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butAddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateUserForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPasswordConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butMakePasswordVisible;
    }
}