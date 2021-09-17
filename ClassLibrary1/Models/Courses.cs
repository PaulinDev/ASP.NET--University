using ClassLibrary1.Core.Data;
using ClassLibrary1.Models.Enum;
using ClassLibrary1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Courses : Entity
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Duration { get; set; }
        public StatusCourse Status { get; set; }
        public TypeCourse Type { get; set; }

        public ICollection<Component> Components;

    }
}
