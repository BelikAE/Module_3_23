using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double n = Convert.ToDouble(Console.ReadLine());
            FactorialAsync(n);
            Console.ReadKey();
        }

        static void Factorial(double n)
        {
            double s = 1;
            for (int i = 1; i < n+1; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s); 
        }

        static async void FactorialAsync(double n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
