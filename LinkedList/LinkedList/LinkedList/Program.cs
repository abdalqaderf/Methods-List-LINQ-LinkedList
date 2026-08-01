using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            LinkedList<string> navigation = new LinkedList<string>();

            navigation.AddFirst("Home");
            navigation.AddLast("About");
            navigation.AddLast("Contact");

            foreach (string page in navigation)
            {
                Console.WriteLine(page);
            }

            //2
            navigation.Remove("About");


            //3
            LinkedListNode<string> contactNode = navigation.Find("Contact");

            if (contactNode != null)
            {
                navigation.AddBefore(contactNode, "About");
            }

            foreach (string page in navigation)
            {
                Console.WriteLine(page);
            }

            //4
            foreach (string page in navigation)
            {
                Console.WriteLine(page);
            }

            //5
            Console.WriteLine( navigation.First.Value);
            Console.WriteLine( navigation.Last.Value);
        }
    }
}
