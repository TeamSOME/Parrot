using System;
using System.Collections.Generic;
using System.Text;

namespace Parrot
{
    public abstract class Parrot
    {
        
        protected readonly bool _isNailed;
        protected readonly int _numberOfCoconuts;
        protected readonly double _voltage;

        public Parrot( int numberOfCoconuts, double voltage, bool isNailed)
        {
            _numberOfCoconuts = numberOfCoconuts;
            _voltage = voltage;
            _isNailed = isNailed;
        }

        public abstract double GetSpeed();

        
        protected  double GetBaseSpeed(double voltage)
        {
            double maxbasespeed_ = 24.0;
            return Math.Min(maxbasespeed_, voltage * GetBaseSpeed());
        }

        protected double GetLoadFactor()
        {
           
            return 9.0;
        }

        protected double GetBaseSpeed()
        {
           //name it/
            return 12.0;
        }
    }
}
