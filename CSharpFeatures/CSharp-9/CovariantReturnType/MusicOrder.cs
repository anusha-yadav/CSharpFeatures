using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_9.CovariantReturnType;

namespace CSharp_9.CovariantReturnType
{
    public class MusicOrder : ProductOrder
    {
        public Music? Product { get; set; }
    }
}
