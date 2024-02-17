using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.InitOnlyProperty
{
    public class Customer
    {
        //Init-Only Properties
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public int Age { get; set; }
    }
}
