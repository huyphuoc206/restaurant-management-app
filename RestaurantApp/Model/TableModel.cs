﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    class TableModel : AbstractModel
    {
        private string name;
        private int seats;
        private int status;

        public string Name { get => name; set => name = value; }
        public int Seats { get => seats; set => seats = value; }
        public int Status { get => status; set => status = value; }
    }
}