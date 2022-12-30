using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Discrete_Mathematics_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x , y , sum = 0;
            Console.WriteLine("Enter the frist number : ");
            int frist = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end number : ");
            int end = int.Parse(Console.ReadLine());

            //frist loop to determine the frist and end number taken from user
            for (int number = frist; number <= end; number++)
            {
                //seconed to determine the divisor frist and end 
                for (int Divisor = 1; Divisor <= end; Divisor++)
                {
                    //frist condition 
                    if (number % Divisor == 0 && number != Divisor)
                    {
                        //add the divisor
                        sum += Divisor;
                    }
                }
                //seconed condition
                if (sum == number)
                {
                    Console.WriteLine(" perfect number is : " + number);
                }
                sum= 0;
                
            }
        }
    }
}
