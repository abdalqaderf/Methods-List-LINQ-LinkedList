using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinking_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            List<int> numbers = new List<int>{10, 20, 30, 40, 50};

            Console.Write("Enter a number: ");
            int target = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            foreach (int number in numbers)
            {
                if (number == target)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            //2
            int evenCounter = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCounter++;
                }
            }

            Console.WriteLine(evenCounter);

            //3
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] < 20)
                {
                    numbers.RemoveAt(i);
                }
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //4
            int largest = 0;
            int secondLargest =0;

            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    secondLargest = largest;
                    largest = number;
                }
                else if (number > secondLargest && number != largest)
                {
                    secondLargest = number;
                }
            }

            if (secondLargest == int.MinValue)
            {
                Console.WriteLine("No second largest number");
            }
            else
            {
                Console.WriteLine("Second largest: " + secondLargest);
            }



        }
    }
}
