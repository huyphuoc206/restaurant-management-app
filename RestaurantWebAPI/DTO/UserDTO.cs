using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DTO
{
    public class UserDTO : AbstractDTO
    {
        private string fullName;
        private string userName;
        private string passWord;
        private string phone;
        private string address;
        private string email;
        private int status;
        private long roleId;

        public string FullName { get => fullName; set => fullName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public int Status { get => status; set => status = value; }
        public long RoleId { get => roleId; set => roleId = value; }
    }
}