using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string>();

            Console.WriteLine("Enter friends names (hit enter twice to quit): ");

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "")
                    break;
                friends.Add(input);
            }

            if (friends.Count == 1)
            {
                Console.WriteLine("{0} likes your post", friends[0]);
                Console.ReadLine();
            }
            else if (friends.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", friends[0], friends[1]);
                Console.ReadLine();
            }
            else if (friends.Count == 3)
            {
                Console.WriteLine("{0}, {1} and {2} other person like your post", friends[0], friends[1], friends.Count - 2);
                Console.ReadLine();
            }
            else if (friends.Count > 3)
            {
                Console.WriteLine("{0}, {1} and {2} other people like your post", friends[0], friends[1], friends.Count - 2);
                Console.ReadLine();
            } else
                Console.WriteLine("Noone likes your post");
                Console.ReadLine();
        }
    }
}
