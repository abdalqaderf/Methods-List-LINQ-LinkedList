using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            List<int> list1 =new List<int> { 1, 2, 3, 4, 5, 6 };
            var newList1 = list1.Where(n => n % 2 == 0);
            foreach (var item in newList1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");
            //2
            List<int> list2 = new List<int> { 1, 2, 3, 2,2, 5, 3 };
            var newList2 = list2.Distinct();
            foreach (var item in newList2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");

            //3
            List<int> list3 = new List<int> { 1, 2, 3, 2, 2, 5, 3 };
            var new3 = list3.Max();
            Console.WriteLine(new3);
            
            
            Console.WriteLine("\n");

            //4
            List<int> list4 = new List<int> { 1, 2, 3, 2, 2, 5, 3 };
            for (int i = list4.Count-1; i >=0; i--)
            {
                Console.Write(list4[i]);
            }

            Console.WriteLine("\n");

            //5
            List<int> list5 = new List<int> { 1, 2, 311, 2, 222, 5, 51 };
            var new5 = list5.Where(n=> n>50);
            Console.WriteLine(new5.Count());


            Console.WriteLine("\n");






        }
    }
}
