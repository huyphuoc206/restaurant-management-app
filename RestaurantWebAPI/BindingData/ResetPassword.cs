﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.BindingData
{
    public class ResetPassword
    {
        private string currentPassword;
        private string newPassword;
        private string newPasswordConfirm;

        public string NewPassword { get => newPassword; set => newPassword = value; }
        public string NewPasswordConfirm { get => newPasswordConfirm; set => newPasswordConfirm = value; }
        public string CurrentPassword { get => currentPassword; set => currentPassword = value; }
    }
}