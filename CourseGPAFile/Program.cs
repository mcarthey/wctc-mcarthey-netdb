using System;
using System.IO;

namespace CourseGPAFile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string file = "courseData.txt";
            string choice;
            do
            {
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                // input response
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (File.Exists(file))
                    {
                        // accumulators needed for GPA
                        int gradePoints = 0;
                        int count = 0;
                        // read data from file
                        StreamReader gradeFile = new StreamReader(file);

                        while (!gradeFile.EndOfStream)
                        {
                            string line = gradeFile.ReadLine();
                            // convert string to array
                            string[] arr = line.Split('|');
                            // display array data
                            Console.WriteLine("Course: {0}, Grade: {1}", arr[0], arr[1]);
                            // add to accumulators
                            gradePoints += arr[1] == "A" ? 4 : arr[1] == "B" ? 3 : arr[1] == "C" ? 2 : arr[1] == "D" ? 1 : 0;
                            count += 1;
                        }
                        // calculate GPA
                        double GPA = (double)gradePoints / count;
                        Console.WriteLine("GPA: {0}", GPA);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }

                }
                else if (choice == "2")
                {
                    // create file from data
                    StreamWriter sw = new StreamWriter("courseData.txt");
                    for (int i = 0; i < 7; i++)
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
                        string name = Console.ReadLine();
                        // prompt for course grade
                        Console.WriteLine("Enter the course grade.");
                        // save the course grade
                        string grade = Console.ReadLine().ToUpper();
                        sw.WriteLine("{0}|{1}", name, grade);
                    }
                    sw.Close();
                    Console.ReadLine();
                }
            } while (choice == "1" || choice == "2");

        }
    }

    class Vehicle {
        public Vehicle()
        {

        }
    }

}
