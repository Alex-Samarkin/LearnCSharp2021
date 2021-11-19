using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// сводка базовых конструкций и концепций C#
/// </summary>
namespace AllInOne
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Console in and out

            /// press cw and Tab Tab
            ///
            Console.WriteLine("Hello world! Проивет, мир"); // вывод
            Console.ReadLine(); // ждем нажатия клавиши Enter
            
            /// вывод строки какк отдельной переменной
            /// 
            string hello = "Hello, username!"; // строка
            // output and waiting for Enter key
            Console.WriteLine(hello);
            Console.ReadLine();

            /// вывод целого числа и десятичной дроби
            /// по отдельности
            /// 
            // output and waiting for Enter key
            int i = 0b1010;
            double x = 0b1010 / 0b11;
            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.ReadLine();

            /// через строку форматирования
            /// строка содержит места заполнения вида {число}
            /// за строкой через запятую - аргументы для вывода
            /// нумеруются с 0
            /// {0} заменяется значением i
            /// {1} заменяется значением x
            /// 
            // output and waiting for Enter key
            Console.WriteLine("i = {0} x = {1}",i,x);
            Console.ReadLine();

            /// через интерполированную строку форматирования
            /// строка начинается со знака $
            /// строка содержит места заполнения вида {имя переменной} или {выражение}
            /// {i} заменяется на значение i
            /// {x} заменяется на значение x
            /// {x*x} заменяется на значение x*x, то есть квадрат x
            /// 
            // output and waiting for Enter key
            Console.WriteLine($"i = {i} x = {x} x^2 = {x*x}");
            Console.ReadLine();

            /// с форматированием (часть 1)
            /// можно через запятую указать, какое количество позиций будет занимать вывод
            /// и его выравнивание
            /// в примере для i отводится 20 позиций, но выравнивание будет отличаться
            /// i = |                  10|
            /// i = | 10                 |
            // output and waiting for Enter key
            Console.WriteLine($"i = |{i,0b10100}|");
            Console.WriteLine($"i = |{i,-0b10100}|");
            Console.ReadLine();

            /// с форматированием (часть 2)
            /// можно задать формат вывода с помощью специальной строки
            /// через двоеточие
            /// 
            // output and waiting for Enter key
            Console.WriteLine($"i = |{i:D5}|"); // пять знаков, decimal
            Console.WriteLine($"i = |{i:C}|");  // валюта, currency
            Console.WriteLine($"x = |{x:F3}|"); // три знака после запятой, fixed 
            Console.WriteLine($"x^2 = |{x*x:G}|");  // общий формат, general
            Console.WriteLine($"x^2 = |{x*x:N6}|");  // числовой формат, Number
            Console.ReadLine();

            /// с форматированием (часть 3)
            /// можно комбинировать формат вывода через запятую-двоеточие
            /// 
            // output and waiting for Enter key
            Console.WriteLine($"i = |{i,0b10100:D5}|"); // пять знаков, decimal
            Console.WriteLine($"i = |{i,-0b10100:C}|");  // валюта, currency
            Console.WriteLine($"x = |{x,0b10100:F3}|"); // три знака после запятой, fixed 
            Console.WriteLine($"x^2 = |{x * x,0b1111:G}|");  // общий формат, general
            Console.WriteLine($"x^2 = |{x * x,-0b1111:N6}|");  // числовой формат, Number
            Console.ReadLine();

            /// консоль - можно задавать различные параметры печати
            /// цвета текста и фона
            /// размер окна
            /// положение курсора
            /// восстановить начальные настройки
            /// 
            Console.ResetColor(); // восстановление исходных настроек
            Console.InputEncoding = Encoding.UTF8; // кодировка ввода (как правило не требуется)
            Console.OutputEncoding = Encoding.UTF8; // кодировка вывода (как правило не требуется)
            Console.WriteLine("♥♦♣♠"); // вывод специальных символов
            Console.ReadLine();

            Console.Clear(); // чистим окно консоли
            Console.WindowWidth = Console.LargestWindowWidth; // задаем максимальную ширину консоли
            Console.WindowHeight = Console.LargestWindowHeight / 0b10; 

            Console.Title = "Новый заголовок"; // Новый заголовок в окне консоли
            Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.DarkBlue; // Цвета для вывода - старый доброый Borland
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear(); // чтобы залить фон цветом
            Console.ReadLine();
            
            Console.WriteLine($"x^2 = |{x * x,0b1111:G}|");  // общий формат, general
            Console.WriteLine($"x^2 = |{x * x,-0b1111:N6}|");  // числовой формат, Number

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"x^2 = |{x * x,0b1111:G}|");  // общий формат, general
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"x^2 = |{x * x,-0b1111:N6}|");  // числовой формат, Number
            Console.ReadLine();

            #endregion

            #region Base types, varaiables and names

            /// Нужно знать эти базовые (простые, атомарные) типы данных:
            /// bool - логические переменные true / false
            /// char - отдельные символы (по умолчанию Unicode) 'a' (иногда задают их коды)
            /// int - целые числа (со знаком) 123
            /// (иногда задают в бинарной или 16-ричной системах счисления)
            /// i =12;
            /// i = 0xC;
            /// i = 0b1100;
            /// double - десятичные дроби (формально - дроби удвоенной точности)
            /// double x = 10.0
            /// 
            /// не атомарные, но все роавно нужные -
            /// string - строка символов
            /// string s = "sdsds"
            /// интерполируемая строка начинается с $, элементы в фигурных скобках  заменяются на их
            /// строковые представления или строковые представления вычисленных выражений
            /// {x>y} заменяется на true или false
            /// $"x= {x} y={y} {x>y}"
            ///
            /// @строки - строки, начинающиеся с символа @ воспринимаются так, как они написаны
            
            /// Все объекты в программе имеют имена - идентификаторы
            /// идентификатор начинается с буквы или _, дальше идут буквы или цифры
            /// НЕЛЬЗЯ начинать идентификатор с цифры
            /// строчные и прописные буквы в идентификаторах - Разные, a и A - РАЗНЫЕ идентификаторы
            ///
            
            /// прежде чем использовать идентификатор, его надо сделать известным программе,
            /// то есть объявить
            /// общая схема: тип имя = значение;
            /// тип задает возможности идентификатора, имя позволяет в дальнейшем к нему обратитиься
            /// КРАЙНЕ РЕКОМЕНДУЕТСЯ сразу же задать объекту осчмысленное значение
            /// string s = ""; // создает пустую строку
            /// int Max_time_sec = 24*60*60; // задает максимальное количество секунд в сутках
            /// double pi_2 = Math.PI*Math.PI; // хранит константу Pi^2 из модуля System.Math
            /// не забываем точку с запятой

            /// существуют объекты, значение которых известно и не меняется - константы
            /// они отмечаются словом const
            /// например, часто константами задают максимальные и минимальные значения типов,
            /// названия цветов или папок по умолчанию
            ///
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            const int CONST_X = 10; // константа целого типа
            // output and waiting for Enter key
            Console.WriteLine($"Min int {Int32.MinValue} Max int {Int32.MaxValue}");
            Console.WriteLine($"Max double {double.MaxValue} Min double {double.MinValue} Epsilon {double.Epsilon} " +
                              $"Neg Infinity {double.NegativeInfinity} Pos Infinity {double.PositiveInfinity}");
            Console.ReadLine();

            /// объекты, которые можно изменять, называются переменными
            /// схема все та же - тип имя = значение;
            /// часто можно ВЫВЕСТИ тип переменной по ее значению
            /// тогда вместо типа ставят ключевое слово var (это необязательно, но удобно)
            ///
            int x1 = 5;
            int y1 = 12;
            var x_y = x1 + y1; // целый тип выведен
            var x_y1 = x1 / y1; // целый тип выведен, так как x1,y1 - целые числа, деление будет нацело
            var x_y2 = (double)x1 / y1; // выведен тип - десятичная дробь
            var x_y3 = Convert.ToDecimal(y1 / x1); // выведен тип decimal, который возвращает функция

            // output and waiting for Enter key
            Console.WriteLine($"x1,y1 = {x1} {y1}");
            Console.WriteLine($"x1+y1 = {x_y}");
            Console.WriteLine($"x1/y1 = {x_y1}");
            Console.WriteLine($"x1/y1 = {x_y2} as double");
            Console.WriteLine($"y1/x1 = {x_y3} divide and convert to decimal"); // ПОЧЕМУ?
                                        // сначала деление нацело 
                                        // затем этот результат (целое число) переводим в десятичную дробь
                                        // поэтому результат 12/5 = 2, но как decimal
            Console.ReadLine();


            #endregion

            #region Types conversion

            /// Часто возникает необходимость в преобразовании одного типа в другой
            /// Есть типы, которые можно использовать в одном выражении, но есть и несовместимые
            /// Обычно действет правило: если в выражении действует несколько типов, то
            /// выходной тип поднимается до наиболее емкого
            /// тем не менее, всегда лучше включать преобразования явно
            ///
            /// Различают: преобразования неявные (implicit), явные (explicit) и преобразования
            /// с помощью специальных методов или функций
            /// Здесь мы рассмотрим преобразования, преимущественно, для числовых типов
            ///
            int i2 = 10; // целое число - в целую переменную
            double x2 = 0.5; // десятичная дробь в переменную того же типа
            double y2 = 8; // целое число в переменную - десятичную дробь, НЕЯВНОЕ ПРЕОБРАЗОВАНИЕ

            // i2 = i2 / x2; // ошибка, нельзя просто так поместить десятичную дробь в целое число
            i2 = (int)(i2 / x2); // сначала делим целое на дробь - тип  поднимается до дроби - неявное преобразование
                                 // (int) - ЯВНО преобразует результат в целое (отбрасывая дробную часть)

            y2 = y2 * y2 + x2 + i2; // i2 преобразуется в double неявно

            // output and waiting for Enter key
            Console.WriteLine($"{i2} {x2} {y2}"); // NB: в фигурных скобках происходит ПРЕОБРАЗОВАНИЕ в строку
            Console.ReadLine();
            
            /// Существует специальный класс-преобразователь типов
            /// Convert.To и далее тип данных, например Convert.ToDouble(x)

            var i3 = Convert.ToDateTime(true);
            // output and waiting for Enter key
            Console.WriteLine(i3);
            Console.ReadLine();

            #endregion
        }
    }
}
