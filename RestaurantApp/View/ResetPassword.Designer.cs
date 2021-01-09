
using System.Windows.Forms;

namespace RestaurantApp.View
{
    partial class ResetPassword
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
            this.text_passwordRp = new System.Windows.Forms.TextBox();
            this.lb_passwordRp = new System.Windows.Forms.Label();
            this.text_newPassword = new System.Windows.Forms.TextBox();
            this.lb_newPassword = new System.Windows.Forms.Label();
            this.text_currentPassword = new System.Windows.Forms.TextBox();
            this.lb_currentPassowrd = new System.Windows.Forms.Label();
            this.errorResetPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_saveResetPassword = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorResetPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // text_passwordRp
            // 
            this.text_passwordRp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_passwordRp.Location = new System.Drawing.Point(270, 139);
            this.text_passwordRp.Name = "text_passwordRp";
            this.text_passwordRp.PasswordChar = '*';
            this.text_passwordRp.Size = new System.Drawing.Size(261, 27);
            this.text_passwordRp.TabIndex = 3;
            this.text_passwordRp.Validating += new System.ComponentModel.CancelEventHandler(this.text_passwordRp_Validating);
            // 
            // lb_passwordRp
            // 
            this.lb_passwordRp.AutoSize = true;
            this.lb_passwordRp.BackColor = System.Drawing.Color.Transparent;
            this.lb_passwordRp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_passwordRp.ForeColor = System.Drawing.Color.Bisque;
            this.lb_passwordRp.Location = new System.Drawing.Point(44, 139);
            this.lb_passwordRp.Name = "lb_passwordRp";
            this.lb_passwordRp.Size = new System.Drawing.Size(207, 23);
            this.lb_passwordRp.TabIndex = 26;
            this.lb_passwordRp.Text = "Nhập lại mật khẩu mới:";
            // 
            // text_newPassword
            // 
            this.text_newPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_newPassword.Location = new System.Drawing.Point(270, 87);
            this.text_newPassword.Name = "text_newPassword";
            this.text_newPassword.PasswordChar = '*';
            this.text_newPassword.Size = new System.Drawing.Size(261, 27);
            this.text_newPassword.TabIndex = 2;
            this.text_newPassword.Validating += new System.ComponentModel.CancelEventHandler(this.text_newPassword_Validating);
            // 
            // lb_newPassword
            // 
            this.lb_newPassword.AutoSize = true;
            this.lb_newPassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_newPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_newPassword.ForeColor = System.Drawing.Color.Bisque;
            this.lb_newPassword.Location = new System.Drawing.Point(44, 91);
            this.lb_newPassword.Name = "lb_newPassword";
            this.lb_newPassword.Size = new System.Drawing.Size(131, 23);
            this.lb_newPassword.TabIndex = 24;
            this.lb_newPassword.Text = "Mật khẩu mới:";
            // 
            // text_currentPassword
            // 
            this.text_currentPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_currentPassword.Location = new System.Drawing.Point(270, 43);
            this.text_currentPassword.Name = "text_currentPassword";
            this.text_currentPassword.PasswordChar = '*';
            this.text_currentPassword.Size = new System.Drawing.Size(261, 27);
            this.text_currentPassword.TabIndex = 1;
            this.text_currentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.text_currentPassword_Validating);
            // 
            // lb_currentPassowrd
            // 
            this.lb_currentPassowrd.AutoSize = true;
            this.lb_currentPassowrd.BackColor = System.Drawing.Color.Transparent;
            this.lb_currentPassowrd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_currentPassowrd.ForeColor = System.Drawing.Color.Bisque;
            this.lb_currentPassowrd.Location = new System.Drawing.Point(44, 47);
            this.lb_currentPassowrd.Name = "lb_currentPassowrd";
            this.lb_currentPassowrd.Size = new System.Drawing.Size(121, 23);
            this.lb_currentPassowrd.TabIndex = 22;
            this.lb_currentPassowrd.Text = "Mật khẩu cũ:";
            // 
            // errorResetPassword
            // 
            this.errorResetPassword.ContainerControl = this;
            // 
            // errorEmpty
            // 
            this.errorEmpty.ContainerControl = this;
            // 
            // btn_saveResetPassword
            // 
            this.btn_saveResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveResetPassword.BackgroundImage = global::RestaurantApp.Properties.Resources.update;
            this.btn_saveResetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_saveResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveResetPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveResetPassword.Location = new System.Drawing.Point(424, 185);
            this.btn_saveResetPassword.Name = "btn_saveResetPassword";
            this.btn_saveResetPassword.Size = new System.Drawing.Size(47, 49);
            this.btn_saveResetPassword.TabIndex = 4;
            this.btn_saveResetPassword.UseVisualStyleBackColor = false;
            ToolTip toolTipResetPassword = new ToolTip();
            toolTipResetPassword.SetToolTip(this.btn_saveResetPassword, "Cập nhật mật khẩu");
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::RestaurantApp.Properties.Resources.Back;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(487, 185);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(44, 49);
            this.btn_back.TabIndex = 5;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            ToolTip toolTipBack = new ToolTip();
            toolTipBack.SetToolTip(this.btn_back, "Quay lại");
            // 
            // ResetPassword
            // 
            this.AcceptButton = this.btn_saveResetPassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestaurantApp.Properties.Resources.password_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 246);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_saveResetPassword);
            this.Controls.Add(this.text_passwordRp);
            this.Controls.Add(this.lb_passwordRp);
            this.Controls.Add(this.text_newPassword);
            this.Controls.Add(this.lb_newPassword);
            this.Controls.Add(this.text_currentPassword);
            this.Controls.Add(this.lb_currentPassowrd);
            this.MaximizeBox = false;
            this.Name = "ResetPassword";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.errorResetPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_passwordRp;
        private System.Windows.Forms.Label lb_passwordRp;
        private System.Windows.Forms.TextBox text_newPassword;
        private System.Windows.Forms.Label lb_newPassword;
        private System.Windows.Forms.TextBox text_currentPassword;
        private System.Windows.Forms.Label lb_currentPassowrd;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_saveResetPassword;
        private ErrorProvider errorResetPassword;
        private ErrorProvider errorEmpty;

        public Button Btn_saveResetPassword { get => btn_saveResetPassword; set => btn_saveResetPassword = value; }
        public TextBox Text_passwordRp { get => text_passwordRp; set => text_passwordRp = value; }
        public TextBox Text_newPassword { get => text_newPassword; set => text_newPassword = value; }
        public TextBox Text_currentPassword { get => text_currentPassword; set => text_currentPassword = value; }
    }
}