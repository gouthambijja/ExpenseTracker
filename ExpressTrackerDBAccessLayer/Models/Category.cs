﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressTrackerDBAccessLayer.Models
{
    public class Category
    {

        public string CategoryId { get; set; }
        public string? Name { get; set; }
        public string? UserId { get; set; }
        public virtual User? User { get; set; }

    }
}
