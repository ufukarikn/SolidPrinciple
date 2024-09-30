using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solidPrinciple
{
    public class DpdGermany : BaseCarrier, IEmailSendable, IEmailMultipleSendable
    {
        public override double GetCarrierSizeCost()
        {
            if (CustomerSize >= 1000)
            {
                return 5;
            }
            else
            {
                return 10;
            }
        }

        public void sendEmail()
        {
            Console.WriteLine("Send Email..");
        }

        public void sendEmails()
        {
            Console.WriteLine("Send Multiple Email..");
        }
    }
}