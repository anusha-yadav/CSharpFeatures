using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_11.StaticAbstarctMembers
{
    public interface IVal
    {
        public static abstract int StaticVal { get; }
        public int InstanceVal { get; }
    }

    public class Class1 : IVal
    {
        public static int StaticVal => 1;
        public virtual int InstanceVal => 1;
    }

    public class Class2 : Class1, IVal
    {
        public new static int StaticVal => 2;
        public override int InstanceVal => 2;
    }

    public class Demo
    {
        public void ConsoleWriteLine<T>(T obj) where T : IVal
        {
            Console.WriteLine("StaticVal : {0}, InstanceVal : {1}", T.StaticVal, obj.InstanceVal);
        }
    }
}
