using RestaurantApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.View
{
    public partial class AccountProfile : Form
    {
        public AccountProfile()
        {
            InitializeComponent();
        }

        private void btn_turnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        internal void loadUserInfo(UserModel user)
        {
            text_fullname.Text = user.FullName;
            text_address.Text = user.Address;
            text_email.Text = user.Email;
            text_phone.Text = user.Phone;
            text_username.Text = user.UserName;
            Date_dob.Value = user.Dob;
            if (user.Gender.Equals("Nam"))
                radio_male.Checked = true;
            else
                radio_female.Checked = true;
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

        private void text_username_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_username, "Bạn phải nhập tên tài khoản.", e);
        }

        private void text_fullname_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_fullname, "Bạn phải nhập họ tên.", e);
        }

        private void text_phone_Validating(object sender, CancelEventArgs e)
        {
            if (!(Regex.Match(text_phone.Text, @"(84|0)+([0-9]{9})\b").Success))
            {
                e.Cancel = true;
                text_phone.Focus();
                errorEmpty.SetError(text_phone, "Bạn phải nhập đúng định dạng số điện thoại.");
            }
            else
            {
                e.Cancel = false;
                errorEmpty.SetError(text_phone, null);
            }
        }

        private void text_email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_email.Text) || !text_email.Text.Contains("@") || !text_email.Text.Contains("."))
            {
                e.Cancel = true;
                text_email.Focus();
                errorEmpty.SetError(text_email, "Bạn phải nhập đúng định dạng email.");
            }
            else
            {
                e.Cancel = false;
                errorEmpty.SetError(text_email, null);
            }
        }

        private void text_address_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_address, "Bạn phải nhập địa chỉ.", e);
        }
    }
}
