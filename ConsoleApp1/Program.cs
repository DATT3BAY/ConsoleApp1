using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADA
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("Число является четным и кратно 10.");
            else if (number % 2 == 0)
                Console.WriteLine("Число является чётным.");
            else if (number % 2 == 0)
                Console.WriteLine("Число кратно 10.");
            else
                Console.WriteLine("Число является нечетным и не кратно 10.");

            Console.ReadKey();
        }
    }
}