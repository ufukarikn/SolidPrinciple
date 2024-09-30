using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solidPrinciple
{
    public class CarrierSizeCost
    {
        public double Calculate (BaseCarrier carrier)
        {
            return carrier.CustomerSize * carrier.GetCarrierSizeCost();
        }
    }
}