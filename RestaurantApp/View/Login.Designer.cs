
namespace RestaurantApp
{
    partial class Form1
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
            this.btn_exit.Location = new System.Drawing.Point(262, 178);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 56);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.Location = new System.Drawing.Point(107, 178);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(98, 56);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // pass_text
            // 
            this.pass_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_text.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_text.Location = new System.Drawing.Point(191, 129);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(215, 29);
            this.pass_text.TabIndex = 7;
            // 
            // user_text
            // 
            this.user_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_text.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_text.Location = new System.Drawing.Point(191, 79);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(215, 29);
            this.user_text.TabIndex = 8;
            // 
            // label_login
            // 
            this.label_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Arial", 16F);
            this.label_login.Location = new System.Drawing.Point(195, 36);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(115, 25);
            this.label_login.TabIndex = 6;
            this.label_login.Text = "Đăng nhập";
            // 
            // label_pass
            // 
            this.label_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(84, 129);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(94, 22);
            this.label_pass.TabIndex = 4;
            this.label_pass.Text = "Mật khẩu :";
            // 
            // label_user
            // 
            this.label_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(84, 79);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(101, 22);
            this.label_user.TabIndex = 5;
            this.label_user.Text = "Tài khoản :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 271);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_user);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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

