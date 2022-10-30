using System;
using System.Collections.Generic;

namespace _06_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string> { "HTML","CSS","JS","REACT","REDUX=TOOLKIT" };

            courses.Add("NEXT JS");
            courses.Remove("CSS");
            Console.WriteLine($"Total course : {courses.Count}");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            //courses.Add("JEQUERY");
            
        }
    }
}
