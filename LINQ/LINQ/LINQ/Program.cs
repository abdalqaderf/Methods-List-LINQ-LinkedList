using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            List<int> numbers = new List<int>{1, 2, 3, 4, 5, 6, 7, 8};

            List<int> oddNumbers = numbers.Where(number => number % 2 != 0).ToList();

            foreach (int number in oddNumbers)
            {
                Console.WriteLine(number);
            }

            //2
            List<int> doubledNumbers = numbers.Select(number => number * 2).ToList();

            //3
            List<int> sortedNumbers = numbers.OrderByDescending(number => number).ToList();

            //4
            int firstNumber = numbers.FirstOrDefault(number => number > 100);

            //5
            double average = numbers.Average();



        }
    }
}
