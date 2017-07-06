using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //When would you use a loop?
            //Why would you use a loop?
            //Nested loops
            //Infinite loops
            //Keywords break and continue

            //For loop
            //Counting and iterarting
            //for(intializer; condition; updater)
            //{
            //  Do something
            //}

            for (int i = 15; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //int i;                  //to use i outside of loop
            //for(i = 15; i> 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("After the loop has run, i now has the value of " + i);  //will display 0

            //Count from 50 to 100
            for (int i = 50; i<=100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
