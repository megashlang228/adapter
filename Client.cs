using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class Client
    {
        public void clientDouble(double a)
        {
            Console.WriteLine(a);
        }

        public void clientInt(int a)
        {
            Console.WriteLine(a);
        }

        public void clientChar(char a)
        {
            Console.WriteLine(a);
        }
    }
}
