using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solidPrinciple
{
    public class DpdPolland : BaseCarrier, IEmailSendable,IGsmSendable
    {
        public override double GetCarrierSizeCost()
        {   
            if (CustomerSize >= 1000)
            {
                return 1.5;
            }
            else
            {
                return 3;
            }
            
        }

        public void OrderSetCarrier()
        {
            Console.WriteLine("Set Carrier..");
        }

        public void sendEmail()
        {
            Console.WriteLine("Send Email..");
        }

        public void sendGsm()
        {
            Console.WriteLine("Send Gsm..");
        }
    }


}