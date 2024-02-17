using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.CovariantReturnType
{
    public abstract class Product
    {
        protected string Name { get;}
        protected int Id { get;}
        protected Product(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public abstract ProductOrder Order(int quantity);
    }
}
