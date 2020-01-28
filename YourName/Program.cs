using System;

namespace YourName
{
    public static class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("How many grades do you have?");
            int numGrades = Convert.ToInt32 (Console.ReadLine());

            string[] name = new string[numGrades];
            string[] grade = new string[numGrades];

            for (int x = 0; x < numGrades; x++)
            {
                Console.WriteLine("What is the class name?");
                name[x] = Console.ReadLine();
                Console.WriteLine("What is the grade?");
                grade[x] = Console.ReadLine();
            }

            for (int x = 0; x < 7; x++)
            {
                Console.WriteLine($"Class {name[x]}");
                Console.WriteLine($"Grade {grade[x]}");
            }
            Console.ReadLine();
        }
    }
}
