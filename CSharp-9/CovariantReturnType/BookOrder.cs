using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.CovariantReturnType
{
    public class BookOrder : ProductOrder
    {
        public Book? Product {  get; set; } 
    }
}
