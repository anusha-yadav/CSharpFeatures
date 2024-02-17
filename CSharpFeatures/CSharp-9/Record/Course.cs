using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.Record
{
    public record Course
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

    }

    public class CourseMaterials
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }
}
