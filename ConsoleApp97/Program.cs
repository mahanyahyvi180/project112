using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp97
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 5;
            Console.WriteLine($"c before postincrement:{c}");
            Console.WriteLine($"postincrementing c:{c++}");
            Console.WriteLine($"c after postincrement:{c}");

            c = 5;
            Console.WriteLine($"c before postincrement:{c}");
            Console.WriteLine($"postincrementing c:{++c}");
            Console.WriteLine($"c after postincrement:{c}");
            Console.ReadLine();
        }
    }
}
