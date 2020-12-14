using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DTO
{
    public class RoleDTO : AbstractDTO
    {
        private string name;
        private string code;

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
    }
}