using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class Original
    {
        public void originalDouble(double a)
        {
            Console.WriteLine(a);
        }

        public void originalInt(int a)
        {
            Console.WriteLine((a*2).ToString());
        }

        public void originalChar(char a)
        {
            Console.WriteLine(a);
            Console.WriteLine(a);
            Console.WriteLine(a);
            Console.WriteLine(a);
            Console.WriteLine(a);
        }
    }
}
