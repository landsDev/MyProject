using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;


            Console.Write("Please, enter the first number: ");
            while (true)
            {

                if (double.TryParse(Console.ReadLine(), out firstValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("It isn't number... Try again.");
                }
            }
            Console.Write("Please, enter the second number: ");
            while(true)
            {
                try
                {
                    secondValue = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("It isn't number... Try again.");
                }
            }
            Console.WriteLine($"The average numbers {firstValue} and {secondValue} " +
                $"is {(firstValue + secondValue) / 2}");
        }
    }
}
