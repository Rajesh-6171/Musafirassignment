
using System;
using System.IO;

namespace Musafirassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Musafir Assignment =====\n");

            // Question 1
            FruitLogic.Run();
            Console.WriteLine();

            // Question 2
            ShowDatabaseDesign();
            Console.WriteLine();

            // Question 3
            LinkedListLogic.Run();
            Console.WriteLine();

            // Question 4
            CompareValues.Run();
        }

        static void ShowDatabaseDesign()
        {
            Console.WriteLine("Question-2. Database Design:");

            string path = Path.Combine(AppContext.BaseDirectory, "DatabaseDesign.txt");

            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("DatabaseDesign.txt file not found.");
            }
        }

    }
}
