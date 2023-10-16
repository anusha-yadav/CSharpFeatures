using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.CovariantReturnType
{
    public class Book : Product
    {
        public string ISBN { get;}
        public Book(string name,int categoryId, string Isbn) : base(name,categoryId)
        {
            ISBN = Isbn;
        }

        public override BookOrder Order(int quantity) => new BookOrder { Quantity = quantity, Product = this };
    }
}
