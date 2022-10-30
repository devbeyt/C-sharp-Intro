using System;
using System.Collections.Generic;
using System.Text;

namespace _08_OOP3
{
    class ToApplyManager
    {
        public void ToApply(ICredyManager credyManager,ILoggerService loggerService)
        {
            credyManager.Calc();
            loggerService.Log();
        }

        public void AllCredies(List<ICredyManager> credies,List<ILoggerService> loggerServices)
        {
            foreach (var credy in credies)
            {
                credy.Calc();
                foreach (var loggers in loggerServices)
                {
                    loggers.Log();
                }
                 
            }
            
        }
    }
}
