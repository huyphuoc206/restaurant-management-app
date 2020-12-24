
namespace RestaurantApp.View
{
    partial class Login
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_username = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.Location = new System.Drawing.Point(308, 121);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 37);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.Location = new System.Drawing.Point(157, 121);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(86, 37);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // text_password
            // 
            this.text_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_password.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password.Location = new System.Drawing.Point(157, 72);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(237, 29);
            this.text_password.TabIndex = 2;
            // 
            // text_username
            // 
            this.text_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_username.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_username.Location = new System.Drawing.Point(157, 22);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(237, 29);
            this.text_username.TabIndex = 1;
            // 
            // label_pass
            // 
            this.label_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(50, 72);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(79, 19);
            this.label_pass.TabIndex = 12;
            this.label_pass.Text = "Mật khẩu:";
            // 
            // label_user
            // 
            this.label_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(50, 22);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(85, 19);
            this.label_user.TabIndex = 13;
            this.label_user.Text = "Tài khoản:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 193);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_user);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_user;
    }
}