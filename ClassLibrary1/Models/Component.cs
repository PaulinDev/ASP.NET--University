﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Component
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public ICollection<Courses> Courses;
    }
}
