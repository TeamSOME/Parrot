using System;
using System.Collections.Generic;
using System.Text;

namespace Parrot
{
    public class European : Parrot
    {
        public European(int numberOfCoconuts, double voltage, bool isNailed) 
            : base(numberOfCoconuts, voltage, isNailed )
        {
            
        }
        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }
    }
}
