﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; } 
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }    
    }
}
