using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите коэффициенты k и b");
                double k = Convert.ToDouble(Console.ReadLine());
                if (k == 0)
                {
                    Console.WriteLine("Коэффициент k должен отличаться от нуля");
                }
                else
                {
                    double b = Convert.ToDouble(Console.ReadLine());
                    LinearEquation le = new LinearEquation(k, b);
                    Console.WriteLine("X = {0}", le.Solve());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
