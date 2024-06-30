using System;
using System.Collections.Generic;
using System.Text;

namespace DuyguAydinRentBike
{
    public abstract class BaseRentOperations
    {
        public abstract string CalculateTotal(Bike selectedBike);
    }
}
