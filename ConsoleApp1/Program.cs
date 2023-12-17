using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine()); //присваивание переменной для факториала
            int b = Factorial(a); //присваивание переменной для результата
            Console.WriteLine($"{a}! = {b}");
            int Factorial (int n)
            {
                if (n == 0)
                {
                    return 1; //вычисление 0!, возврат 1
                }
                else
                {
                    return n * Factorial(n - 1); //вычисление факториала
                }
            }
            Console.ReadKey();
        }
    }
}
