using System;

namespace _01_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoryName = "Notebooks";
            Console.WriteLine(categoryName);

            int initiAlCount = 0;
            double dolarToday = 7.45;
            decimal unitPrice = 1200;
            var userName = "Jhone";
            var increase = 10;
            bool isLoading = true;

            if (isLoading)
            {
                Console.WriteLine("Please wait...");
            }
            else
            {
                Console.WriteLine($"Welcome : {userName}");
            }
        }
    }
}
