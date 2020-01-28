using System;

namespace CourseGPAArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // array for saving course names
            string[] names = new string[7];
            // array for saving course grades
            string[] grades = new string[7];
            // counter
            int i;
            for (i = 0; i < 7; i++)
            {
                // ask a question
                Console.WriteLine("Enter a course (Y/N)?");
                // input the response
                string resp = Console.ReadLine().ToUpper();
                // if the response is anything other than "Y", stop asking
                if (resp != "Y") { break; }
                // prompt for course name
                Console.WriteLine("Enter the course name.");
                // save the course name
                names[i] = Console.ReadLine();
                // prompt for course grade
                Console.WriteLine("Enter the course grade.");
                // save the course grade
                grades[i] = Console.ReadLine().ToUpper();
            }
            // clear display
            Console.Clear();

            // accumulator needed to calc GPA
            int gradePoints = 0;
            // loop thru array
            for (int x = 0; x < i; x++)
            {
                // grade points are determined based on grade (A=4, B=3, C=2, D=1, F=0)
                int gp = grades[x] == "A" ? 4 : grades[x] == "B" ? 3 : grades[x] == "C" ? 2 : grades[x] == "D" ? 1 : 0;
                // add to accumulator
                gradePoints += gp;
                // display course name, grade, and grade points
                Console.WriteLine("Course: {0}, Grade: {1}, Points: {2}", names[x], grades[x], gp);
            }
            // calc GPA
            double GPA = (double)gradePoints / i;
            // display GPA
            Console.WriteLine("GPA: {0}", GPA);
        }
    }
}
