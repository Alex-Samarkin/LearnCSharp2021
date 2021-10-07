using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");

            string name = Console.ReadLine();

            Console.WriteLine($"Здрваствуйте, {name}");
        }
    }
}
