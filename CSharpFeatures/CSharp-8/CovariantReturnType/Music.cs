using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.CovariantReturnType
{
    public class Music : Product
    {
        protected Format Format { get;}
        public Music(string name,int categoryId,Format format) : base(name,categoryId)
        {
            Format = format;
        }

        public override ProductOrder Order(int quantity) => new MusicOrder { Product = this,Quantity = quantity};
    }
}
