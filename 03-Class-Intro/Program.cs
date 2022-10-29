using System;

namespace _03_Class_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------- Class ---------------------");

            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C-sharp";
            course1.Teacher = "Engin Demirog";

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Next js";
            course2.Teacher = "Maria";

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "React js";
            course3.Teacher = "Khan";

            Console.WriteLine("-------------------- Array ---------------------");

            Course[] courses = new Course[] { course1,course2,course3 };

            foreach (var course in courses)
            {
                Console.WriteLine($"Course {course.Id}  {course.Name} Teacher is {course.Teacher} ");
            }
        }
    }
}
