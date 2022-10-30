using System;
using System.Collections.Generic;
using System.Text;

namespace _08_OOP3
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to Db");
        }
    }
}
