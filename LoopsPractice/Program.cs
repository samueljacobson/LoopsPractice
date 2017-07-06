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

            //for (int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //int i;                  //to use i outside of loop
            //for(i = 15; i> 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("After the loop has run, i now has the value of " + i);  //will display 0

            //Count from 50 to 100
            //for (int i = 50; i<=100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            string greeting = "My name is Little Bill.";
            //The .Split() method takes a string and turns in into an array of smaller
            //strings (substrings). It defauls the split on spaces.
            string[] wordsInGreeting = greeting.Split();
            for(int i = 0; i < wordsInGreeting.Length; i++)
            {
                Console.WriteLine(wordsInGreeting[i]);
            }

            //Create an array called day with elements Monday, Tuesday, Wednesday
            //Using a for loop, print the elements of the days array
            string[] days = { "Monday", "Tuesday", "Wednesday" };
            for(int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

            //Start with the string "Once upon a time" and create an array called
            //storyWords using the Split method. Reverse the order of the elements in the array using a for loop, print each word
            string story = "Once upon a time.";
            string[] storyWords = story.Split();
            Array.Reverse(storyWords);
            for(int i = 0; i < storyWords.Length; i++)
            {
                Console.WriteLine(storyWords[i]);
            }

            //Calculate the product of 1 through 10 using a for loop, print the product
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            int product = 1;
            for (int i = 1; i <= 10; i++)
            {
                product = product * i;
            }
            Console.WriteLine(product);


            //Foreach
            //Used to iterate over a collection (eg list or array)
            //foreach(dataType variable in collection)
            //{
            //Do something
            //}

            string[] calendar = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            //Always start with keyword foreach
            foreach(string month in calendar)
            {
                Console.WriteLine(month);
            }
            //foreach loops allow the temporary variable to "know" to assign itself to each element in the collection, one at a time
            //Always goes from beginning to end (but can insert a break)

            //Create an array of 6 musicians
            //Using a foreach loop, print each musician's name
            string[] musicians = { "Pink Floyd", "Riccardo Muti", "Marc-Andre Hamelin", "Roger Waters", "David Gilmour", "Philip Glass" };
            foreach(string name in musicians)
            {
                Console.WriteLine(name);
            }
        }
    }
}
