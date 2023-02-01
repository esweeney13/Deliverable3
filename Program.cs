/*
Author: Erik Sweeney
Date: 1/31/23
Description: Deliverable 3
*/

using System;

namespace Loops_Example_1
{
    class Program
    {
        private static int input;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer positive number");

            /*Boolean done = false;

            while (!done)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine("The entry is: " + input);
                    done = true;
                }
                catch
                {
                    Console.WriteLine("Enter an integer positive number");
                }
            }*/



            /* for (int i = 0; i < input; i++)
            {
            int even = 2 * i;

            if (even > input)
            {
                 break;
            }

            Console.WriteLine(even + " is an even number");
        }*/

            /*int i = 0; // counter
            int even = 0;
            while (even < input)
            {
                Console.WriteLine(even + " is an even number");
                i++;
                even = 2 * i;
            }*/
            int i = 0;
            int even = 0;

            do
            {
                Console.WriteLine(even + "is an even number");
                even = 2 * i;
                i++;
            }

            while (even < input);



        }
    }
}