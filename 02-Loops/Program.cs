using System;

namespace _02_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------for 1 --------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string course1 = "HTML";
            string course2 = "CSS";
            string course3 = "JAVASCRIPT";
            string course4 = "REACT";

            string[] courses = new string[] { course1,course2,course3,course4};

            Console.WriteLine("------------------------for 2 --------------------------");

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("------------------------foreach----------------------");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            
        }
    }
}
