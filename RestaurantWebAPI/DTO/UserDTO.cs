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
        private DateTime dob;
        private string gender;
        private int status;
        private RoleDTO role;

        public string FullName { get => fullName; set => fullName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public int Status { get => status; set => status = value; }
        public string Gender { get => gender; set => gender = value; }
        public RoleDTO Role { get => role; set => role = value; }
        public DateTime Dob { get => dob; set => dob = value; }
    }
}