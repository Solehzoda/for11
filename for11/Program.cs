using System;

namespace for11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            double N = Convert.ToDouble(Console.ReadLine());

            double sum = 0.0;

            for (double i = N; i <= 2 * N; i++)
            {
                sum += i * i;
            }

            Console.WriteLine($"Сумма будет {sum}");
        }
    }
}