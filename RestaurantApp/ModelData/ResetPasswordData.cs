using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApp.BindingData
{
    public class ResetPasswordData
    {
        private string currentPassword;
        private string newPassword;
        private string newPasswordConfirm;

        public ResetPasswordData(string currentPassword, string newPassword, string newPasswordConfirm)
        {
            this.currentPassword = currentPassword;
            this.newPassword = newPassword;
            this.newPasswordConfirm = newPasswordConfirm;
        }

        public string NewPassword { get => newPassword; set => newPassword = value; }
        public string NewPasswordConfirm { get => newPasswordConfirm; set => newPasswordConfirm = value; }
        public string CurrentPassword { get => currentPassword; set => currentPassword = value; }
    }
}