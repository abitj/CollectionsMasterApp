using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            // Create an integer Array of size 50
            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            //Print the first number of the array
            //Print the last number of the array  
            //Use this method to print out your numbers from arrays or lists
            
            var numbers = new int[50];
            Populater(numbers);
            Console.WriteLine($"The first number is {numbers[0]} in the array of 50");
            Console.WriteLine($"The last number is {numbers[numbers.Length -1]} in the array of 50");
            NumberPrinter(numbers);
            Console.WriteLine("All Numbers Original");
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
           
            Console.WriteLine("All Numbers Reversed:");
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            //Sort the array in order now

            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            Console.WriteLine("-------------------");
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

          
            //Create an integer List
            //Print the capacity of the list to the console
            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            //Print the new capacity

            var numberList = new List<int>();
            Console.WriteLine($"{numberList.Capacity}");
            Populater(numberList);
            NumberPrinter(numberList);
            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            //Print all numbers in the list

            int userInput;
            bool isNumber;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isNumber = int.TryParse(Console.ReadLine(), out userInput);

            } while (!isNumber);
            NumberChecker(numberList, userInput);
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers:");
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine();
            Console.WriteLine("Odds Only!!");
            OddKiller(numberList);
           
            

            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            numberList.Sort();
            NumberPrinter(numberList);

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var myArray = numberList.ToArray();
            //Clear the list
            numberList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0;  i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
                NumberPrinter(numbers);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int i = numberList.Count - 1; i >= 0;  i--)
            { 
                if (numberList [i] % 2 != 0)
                    {
                        numberList.Remove(numberList[i]);
                    }

            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if(numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes we have the number you are looking for.");
            }
            else
            {
                Console.WriteLine($"Nope! We got none like that number");
                Console.WriteLine("------------------");
                Console.WriteLine();

            }
        }

        private static void Populater(List<int> numberList)
            
        {
            while (numberList.Count < 50)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);
                numberList.Add(number);
            }
                

        }

        private static void Populater(int[] numbers)
        {
            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50); 
            }
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
