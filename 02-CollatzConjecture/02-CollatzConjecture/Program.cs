using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CollatzConjecture
{
    class Program
    {
        static int GetIntegerFromConsole(string prompt)
        {
            Console.WriteLine(prompt);
            string inputUser = Console.ReadLine();
            int x = int.Parse(inputUser);
            return x;
        }
        static void Main(string[] args)
        {
            int correctNumber = GetIntegerFromConsole("Enter a number: ");
            int originalInput = correctNumber;

            //insert clicker to enable counting the cycles
            int clicker = 0;

            var max = 0;
            var maxcount = 0;

            //place a while loop that will run whenever the number is larger than one (1)
            while (correctNumber > 1)
            {
                //place clicker inside the while/if so it can count the actual cycles
                clicker = clicker + 1;


               

                if (correctNumber % 2 == 0)
                {
                    //when integer is even then halve it
                    correctNumber = (correctNumber / 2);
               
                }
                else
                {
                    //when integer is odd then triple it and add 1
                    correctNumber = (correctNumber * 3 + 1);
                 
                }
                //figure out the highest value in the cycle
                /* { int[] data = { 1, ?? };
                   int large = Data.Max;
                   Console.WriteLine("The value reaches its peak at: " + large);
                 }*/

         

                if (correctNumber > max)
                {
                    max = correctNumber;
                    maxcount = clicker;
                    
                }
                Console.WriteLine(correctNumber);
            }
            Console.WriteLine("It takes " + clicker + " steps to reach 1 from " + originalInput);
            Console.WriteLine("The value reaches its peak at: " + max + " at step " + maxcount);
            Console.ReadLine();
        }
    }
}
