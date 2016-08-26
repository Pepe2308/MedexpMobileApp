﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedexpMobile.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CURP { get; set; }
        public string Religion { get; set; }
        public string Service { get; set; }
        public int Age { get; set; }
        public string Address { get; set; } 
        public string CellphoneNumber { get; set; }
        public string Email { get; set; }
        public string Hospital { get; set; }
        public string BloodType { get; set; }
        public string EmergencyNumber { get; set; }
        public string Photo { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
