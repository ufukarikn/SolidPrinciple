using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solidPrinciple
{
    public abstract class BaseCarrier
    {
        public int CustomerSize {get; set;}

        public abstract double GetCarrierSizeCost();

    }
}