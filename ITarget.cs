using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal interface ITarget
    {
        void clientDouble(double a);

        void clientInt(int a);

        void clientChar(char a);
    }
}
