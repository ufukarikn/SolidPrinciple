using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solidPrinciple
{
    public class ExceptionLogger
    {
        private readonly ILogger logger;
         
        public ExceptionLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Log(string logInfo)
        {
            logger.Log(logInfo);
        }
        
    }

    public interface ILogger
    {
        void Log(string logInfo);
    }

    public class TimeoutExceptionLogger : ILogger
    {
        public void Log(string logInfo)
        {
            //TimeOutLogger
        }
    }

    public class OtherExceptionLogger : ILogger
    {
        public void Log(string logInfo)
        {
            //OuterLooger
        }
    }
}