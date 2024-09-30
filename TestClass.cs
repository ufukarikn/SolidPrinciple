using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solidPrinciple
{
    public class TestClass 
    {
        public void ActionOrder() //Dependency Inversion Principle
        {
            try
            {
                var Order1 = new DpdPolland();

                Order1.OrderSetCarrier();

                Order1.sendEmail();
            }
            catch (TimeoutException e)
            {
                new ExceptionLogger(new TimeoutExceptionLogger()).Log(e.Message);
            }
            catch (Exception e)
            {
                new ExceptionLogger(new OtherExceptionLogger()).Log(e.Message);
            }

        }
    }
}