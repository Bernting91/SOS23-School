using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flygplats_Uppgift
{
    internal class Airplane
    {
        public String Size { get; set; }
        public String AirPlaneName { get; set; }
        public int PassengerLimit { get; set; }

        public Airplane(int passengerLimit, String size, String airplaneName)
        {
            this.PassengerLimit = passengerLimit;
            this.Size = size;
            this.AirPlaneName = airplaneName;
        }

        public override String ToString()
        {
            return "Name of airplane: " + AirPlaneName + ". Size of plane: " + Size + ". Maximum amount of passengers: " + PassengerLimit;
        }
    }
}
