using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Discrete_Mathematics_1
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Enter a number ");
            int number = int.Parse(Console.ReadLine());

            int y;
            bool current = false;

            for (int i = 2; i <= number; i++)
            {
                for (y = 2; y < i; y++)
                {
                    if (i % y == 0)
                    {
                        current = true;
                    }
                }
                if (current == false)
                {
                    Console.WriteLine("The prime number is {0} " , y); 
                }
                else current = false;
            }
        }
    }
}
   

