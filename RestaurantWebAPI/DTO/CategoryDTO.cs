﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DTO
{
    public class CategoryDTO : AbstractDTO
    {
        private string name;
        private int status;

        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
    }
}