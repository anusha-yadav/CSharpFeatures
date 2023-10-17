using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.StaticAnonymous
{
    public class Base
    {
        private const string formattedText = "{0} It was developed by Microsoft's Anders in the year 2000";

        void DisplayText(Func<string,string> func)
        {
            Console.WriteLine(func("C# is a popular programming language"));
        }

        public void Display()
        {
            DisplayText(static text=> string.Format(formattedText,text));
            Console.Read();
        }
    }
}
