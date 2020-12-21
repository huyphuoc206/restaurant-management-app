
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
            this.pass_text = new System.Windows.Forms.TextBox();
            this.user_text = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.Location = new System.Drawing.Point(331, 174);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 37);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.Location = new System.Drawing.Point(180, 174);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(86, 37);
            this.btn_login.TabIndex = 18;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pass_text
            // 
            this.pass_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_text.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_text.Location = new System.Drawing.Point(180, 125);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(237, 29);
            this.pass_text.TabIndex = 15;
            // 
            // user_text
            // 
            this.user_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_text.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_text.Location = new System.Drawing.Point(180, 75);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(237, 29);
            this.user_text.TabIndex = 16;
            // 
            // label_login
            // 
            this.label_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Arial", 16F);
            this.label_login.Location = new System.Drawing.Point(184, 32);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(115, 25);
            this.label_login.TabIndex = 14;
            this.label_login.Text = "Đăng nhập";
            // 
            // label_pass
            // 
            this.label_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(73, 125);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(84, 19);
            this.label_pass.TabIndex = 12;
            this.label_pass.Text = "Mật khẩu :";
            // 
            // label_user
            // 
            this.label_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(73, 75);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(90, 19);
            this.label_user.TabIndex = 13;
            this.label_user.Text = "Tài khoản :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 242);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_user);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_user;
    }
}