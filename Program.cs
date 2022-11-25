using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("client");
            client.clientChar('a');
            client.clientInt(8);
            client.clientDouble(4.43);
            Console.WriteLine();

            Console.WriteLine("adapter");
            Adapter adapter = new Adapter();
            adapter.clientChar('a');
            adapter.clientInt(8);
            adapter.clientDouble(4.43);

            Console.ReadLine();
        }
    }
}
