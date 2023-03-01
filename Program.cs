using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int maxNumber = rand.Next(0, 101);
            int sum = 0;

            for ( int i = 3; i <= maxNumber; i++ ) 
            {

                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;                 
                }
                
            }
            Console.WriteLine(" Рандомное число " + maxNumber + " Сумма всех чисел кратных 3 или 5 до " + maxNumber + " равна " + sum);
        }
    }
}
