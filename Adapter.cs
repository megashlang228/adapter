using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    public class Adapter : ITarget
    {
        private Original cl;
        public Adapter()
        {
            cl = new Original();
        }
        public void clientChar(char a)
        {
            cl.originalChar(a);
        }

        public void clientDouble(double a)
        {
            cl.originalDouble(a);
        }

        public void clientInt(int a)
        {
            cl.originalInt(a);
        }
    }
}
