
using System;
using System.Collections.Generic;
using System.Linq;

namespace Musafirassignment
{
    public class FruitLogic
    {
        public static void Run()
        {
            Console.WriteLine("Question-1. Unique Fruits:");

            var list1 = new List<string> { "mango", "banana", "orange", "banana" };
            var list2 = new List<string> { "apple", "mango", "watermelon" };

            Console.WriteLine("List 1: mango, banana, orange, banana");
            Console.WriteLine("List 2: apple, mango, watermelon");

            var result = list1
                .Concat(list2)
                .GroupBy(f => f)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key);

            Console.WriteLine("Result:");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
