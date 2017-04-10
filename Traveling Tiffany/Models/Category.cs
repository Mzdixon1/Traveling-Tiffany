﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traveling_Tiffany.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}