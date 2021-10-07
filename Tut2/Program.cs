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

            Console.ReadLine();

            Console.WriteLine("Введите число");
            string value = Console.ReadLine();
            // лучше проверить, что все ОК
            /*
             * if(value == "") value = "0.0";
             */
            
            double x = Double.Parse(value);
            // лучше проверить, что преобразование прошло нормально

            Console.WriteLine($"x= {x} x^2= {x*x} x^3= {x*x*x} x^4= {x*x*x*x}");
            Console.WriteLine($"1/x= {1/x} 1/x^2= {1/(x * x)} 1/x^3= {1/(x * x * x)} 1/x^4= {1/(x * x * x * x)}");

            // добавьте необходимое
            Console.WriteLine("Если это радиус:");
            Console.WriteLine("Длина окружности {Math.PI*x} Площадь круга {Math.PI*x*x} Объем сферы {} ");

            // добавьте необходимое
            Console.WriteLine("Если это угол в радианах:");
            Console.WriteLine("Sin {Math.Sin(x)} Cos {Math.Cos(x)} Tan {Math.Tan(x)} Cotan {1.0/Math.Tan(x)}");

            Console.ReadLine();



        }
    }
}
