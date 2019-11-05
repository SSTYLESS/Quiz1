using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Reverse Pyramid
            /* Console.WriteLine("Enter the number of rows:");
             int a = Convert.ToInt32(Console.ReadLine());

             for (int i = a; i > 0; i--)
             {
                 for (int j = 0; j < i; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();
         */


            //2.The sum of all digits
            /*  Console.WriteLine("Enter a Integer: ");
              int number = Convert.ToInt16(Console.ReadLine());

              int sum = 0;

              while(number > 0)
              {
                  sum += number % 10;
                  number /=10;

              }

              Console.Write("The sum of all digits is: {0}",sum);
              Console.ReadKey();*/

            //3. Calculate N Factorial
            int i, total = 1, number;
            Console.WriteLine("Enter a factorial number: ");
            number = int.Parse(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                total = total * i;
            }
            Console.Write("The Factorial total of number " + number + " is: " + total);
            Console.ReadKey();


        }
 
        }
    }

