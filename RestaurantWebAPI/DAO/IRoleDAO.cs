﻿using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.DAO
{
    interface IRoleDAO
    {
        List<RoleDTO> FindAll();
    }
}
