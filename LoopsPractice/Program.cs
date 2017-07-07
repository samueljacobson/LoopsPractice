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
            ////When would you use a loop?
            ////Why would you use a loop?
            ////Nested loops
            ////Infinite loops
            ////Keywords break and continue

            ////For loop
            ////Counting and iterarting
            ////for (intializer; condition; updater)
            ////{
            ////    Do something
            ////}

            //for (int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //int i;                  //to use i outside of loop
            //for (i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("After the loop has run, i now has the value of " + i);  //will display 0

            ////Count from 50 to 100
            //for (int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string greeting = "My name is Little Bill.";
            ////The.Split() method takes a string and turns in into an array of smaller
            ////strings(substrings).It defauls the split on spaces.
            //string[] wordsInGreeting = greeting.Split();
            //for (int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            ////Create an array called day with elements Monday, Tuesday, Wednesday
            ////Using a for loop, print the elements of the days array
            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            ////Start with the string "Once upon a time" and create an array called
            ////storyWords using the Split method.Reverse the order of the elements in the array using a for loop, print each word

            //string story = "Once upon a time.";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            ////Calculate the product of 1 through 10 using a for loop, print the product
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //int product = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);


            ////Foreach
            ////Used to iterate over a collection(eg list or array)
            ////foreach (dataType variable in collection)
            ////{
            ////    Do something
            ////}

            //string[] calendar = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            ////Always start with keyword foreach
            //foreach (string month in calendar)
            //{
            //    Console.WriteLine(month);
            //}
            ////foreach loops allow the temporary variable to "know" to assign itself to each element in the collection, one at a time
            ////Always goes from beginning to end(but can insert a break)

            ////Create an array of 6 musicians
            ////Using a foreach loop, print each musician's name
            //string[] musicians = { "Pink Floyd", "Riccardo Muti", "Marc-Andre Hamelin", "Roger Waters", "David Gilmour", "Philip Glass" };
            //foreach (string name in musicians)
            //{
            //    Console.WriteLine(name);
            //}

            ////While
            ////Code will run while condition is met (i.e.TRUE - boolean)
            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while (firstName.ToUpper() == "DANIEL")
            //{
            //    Console.WriteLine("Dude, you are amazing.");
            //    break;
            //}

            ////If user wants to continue playing game
            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();  //can also put .ToUpper after Console.ReadLine()
            //while (playAgain.ToUpper() == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            ////Do -while
            //// Used when you want a chunk of code to run AT LEAST once, but repeat only if the While condition is met
            ////do
            ////{
            ////    Do something
            ////}
            ////while (condition);

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine().ToUpper();
            //}
            //while (playAgain == "YES");

            ////Ask the user for the class that they would like to add to their GPA calculation
            ////Ask the user for the letter grade for the class
            ////Ask the user if they have another class they would like to add to GPA
            ////Using a do-while loop, repeat the code if the user says "yes"

            //string anotherClass;
            //do
            //{
            //    Console.WriteLine("Which class would you like to add to your GPA calculation?");
            //    string classAdd = Console.ReadLine();
            //    Console.WriteLine("What was your grade in " + classAdd + "?");
            //    char classGrade = char.Parse(Console.ReadLine());
            //    Console.WriteLine("Do you have another class you'd like to add? YES/NO");
            //    anotherClass = Console.ReadLine().ToUpper();
            //}
            //while (anotherClass == "YES");

            ////Nested loops
            ////Loop within a loop
            ////Example - clock with seconds

            ////Create a nested loop structure that prints:
            //// 1234
            //// 1234

            //for (int i = 1; i <= 2; i++)  //i is number of rows
            //{
            //    for (int j = 1; j <= 4; j++)  //j is number of columns, since greater than #rows, make inner loop
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            ////Print a triangle
            ////Outer loop will go line by line
            ////The inner loop will go over different elements in the line.
            ////Result:
            ////1
            ////1 2
            ////1 2 3
            ////1 2 3 4 ...

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("How many rows do you want in your triangle?");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////FizzBuzz with nested loops
            //Console.WriteLine("Let's Play FizzBuzz!");
            //Console.WriteLine("Please enter your FIZZ number");
            //int fizz = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your BUZZ number");
            //int buzz = int.Parse(Console.ReadLine());
            //Console.WriteLine("What number would you like me to count to? (Pick a high one)");
            //int endNumber = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= endNumber; i++)
            //{
            //    if (i % fizz == 0 && i % buzz == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz!");
            //    }
            //    else if (i % fizz == 0)
            //    {
            //        Console.WriteLine("Fizz!");
            //    }
            //    else if (i % buzz == 0)
            //    {
            //        Console.WriteLine("Buzz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////Additional practice
            ////Write a console application that prints out hello world 10 times to the console
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Hello world");
            //}

            ////Write a console application and print out the numbers 1-100
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////Create a string variable and print all the elements on that string to the console
            //string message = "hello world";
            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.WriteLine(message[i]);
            //}

            //foreach (char elements in message)
            //{
            //    Console.WriteLine(elements);
            //}

            ////Ask user for a word, print number of vowels
            //Console.WriteLine("Please enter a word.");
            //string words = Console.ReadLine();
            //int vowelCount = 0;
            //foreach (char letter in words)
            //{
            //    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //    {
            //        vowelCount += 1;
            //    }
            //}
            //Console.WriteLine(vowelCount);  ////outside of loop

            ////Ask user to enter a number and how many times it should be repeated
            //Console.WriteLine("Please enter a word.");
            //string word = Console.ReadLine();
            //Console.WriteLine("How many times would you like " + word + " repeated?");
            //int repeat = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= repeat; i++)
            //{
            //    Console.WriteLine(word);
            //}

            //Print a 5 x 5 multiplication table using nested loops
            //int multNum = 1;
            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <=5; j++)
            //    {
            //        Console.Write(multNum * j + " ");
            //    }
            //    multNum += 1;
            //    Console.WriteLine();
            //}

            ////Create array of favorite movies, print out each unless starts with a vowel
            //string[] faveMovies = { "Star Wars", "Anchorman", "Avatar", "Serenity", "Super Troopers" };
            //foreach(string movie in faveMovies)
            //{
            //    if(movie.StartsWith("A"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("E"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("I"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("O"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("U"))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(movie);
            //    }
            //}


        }
    }
}
