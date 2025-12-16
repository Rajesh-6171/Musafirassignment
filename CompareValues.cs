
using System.Collections.Generic;
using System;

namespace Musafirassignment
{
    public class CompareValues
    {
        public static void Run()
        {
            Console.WriteLine("Question-4. Compare A and B:");

            int A = 10;
            int B = 20;

            Console.WriteLine("A = 10, B = 20");
            Console.WriteLine("Result: " + FindGreater(A, B));
        }

        public static string FindGreater(int A, int B)
        {
            var map = new Dictionary<bool, string>
            {
                { true, "A is greater" },
                { false, "B is greater" }
            };

            return map[A > B];
        }
    }
}
