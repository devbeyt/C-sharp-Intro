using System;
using System.Collections.Generic;

namespace _08_OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseCredy houseCredy = new HouseCredy();
            //houseCredy.Calc();

            TransportCredy transportCredy = new TransportCredy();
            //transportCredy.Calc();



            ICredyManager houseCredy2 = new HouseCredy();
            //houseCredy2.Calc();
            ICredyManager transportCredy2 = new TransportCredy();
            //transportCredy.Calc();

            ILoggerService smsLogger = new SmsLoggerService();
            ToApplyManager toApplyManager = new ToApplyManager();
            toApplyManager.ToApply(houseCredy,smsLogger);
           

            List<ICredyManager> credies = new List<ICredyManager> { houseCredy,transportCredy};

            List<ILoggerService> loggers = new List<ILoggerService> { new DataBaseLoggerService(), new SmsLoggerService()};
            toApplyManager.AllCredies(credies,loggers);

        }
    }
}
