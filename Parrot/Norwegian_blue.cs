using System;
using System.Collections.Generic;
using System.Text;

namespace Parrot
{
    public class Norwegian_blue : Parrot
    {

        public Norwegian_blue(int numberOfCoconuts, double voltage, bool isNailed)
           : base(numberOfCoconuts, voltage, isNailed)
        {

        }
        public override double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }
    }
}
