using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите дробное число: ");
                // разделитель в дробных числах для разных регионов
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };
                try
                {
                    double userIput = double.Parse(Console.ReadLine(), numberFormatInfo);
                    Console.WriteLine("OK, вы ввели " + userIput);

                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный формат ввода!");
                }
            }
        }
    }
}
