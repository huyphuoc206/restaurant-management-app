using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.View
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Clear()
        {
            this.text_currentPassword.Text = "";
            this.text_newPassword.Text = "";
            this.text_passwordRp.Text = "";
        }

        private void checkErrorEmpty(TextBox textBox, string message, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorEmpty.SetError(textBox, message);
            }
            else
            {
                e.Cancel = false;
                errorEmpty.SetError(textBox, null);
            }
        }

        private void text_currentPassword_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_currentPassword, "Bạn phải nhập mật khẩu hiện tại.", e);
        }

        private void text_newPassword_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_newPassword, "Bạn phải nhập mật khẩu mới.", e);
        }

        private void text_passwordRp_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_passwordRp, "Bạn phải nhập lại mật khẩu mới.", e);
        }
    }
}
