using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            List<int> firstList = new List<int>{ 1, 2, 3, 4, 5};

            List<int> secondList = new List<int>{ 3, 4, 5, 6, 7};

            List<int> commonNumbers = firstList.Intersect(secondList).ToList();

            foreach (int number in commonNumbers)
            {
                Console.WriteLine(number);
            }

            //2
            List<int> combinedList = firstList.Concat(secondList).ToList();

            foreach (int number in combinedList)
            {
                Console.WriteLine(number);
            }

            //3
            List<int> uniqueNumbers = combinedList.Distinct().ToList();

            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }

            //4
            Dictionary<string, int> stdScore = new Dictionary<string, int>
            {
                { "Ahmad", 60 },
                { "Ali", 70 },
                { "Ayman", 80 }
            };

            List<int> scores = stdScore.Values.ToList();

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            //5
            Dictionary<string, int> filteredItems = stdScore.Where(item => item.Value > 100)
                .ToDictionary(item => item.Key, item => item.Value);

  
        }
    }
}
