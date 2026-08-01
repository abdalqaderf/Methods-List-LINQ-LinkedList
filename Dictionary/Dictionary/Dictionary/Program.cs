using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            Dictionary< string, int> stdScore=new Dictionary< string, int>
            {
                {"Ahmad" ,60 },
                {"Ali" , 81 },
                {"Ayman" , 90 }
            };
            foreach (var item in stdScore)
            {
                if (item.Value>80)
                Console.WriteLine(item.Key + " " + item.Value);
            }


            Console.WriteLine("\n");

            //2
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            if (stdScore.ContainsKey(name))
            {
                Console.WriteLine("Score: " + stdScore[name]);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine("\n");


            //3
            int totalScores = stdScore.Values.Sum();

            Console.WriteLine("Total scores: " + totalScores);

            //4
            List<string> studentsToRemove = stdScore
            .Where(student => student.Value < 50)
            .Select(student => student.Key)
            .ToList();

            foreach (string studentName in studentsToRemove)
            {
                stdScore.Remove(studentName);
            }

            foreach (var student in stdScore)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }


            Console.WriteLine("\n");

            //5
            var highestStudent = stdScore
            .OrderByDescending(student => student.Value)
            .First();

            Console.WriteLine(highestStudent.Key + " " + highestStudent.Value);

        }
    }
}
