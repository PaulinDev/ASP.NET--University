using ClassLibrary1.Core.Data;
using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public class Teacher : Entity
    {
        public string Name { get; set; }
        public ICollection<Component> Components;
    }
}
