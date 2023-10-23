using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flygplats_Uppgift
{
    internal class Flight
    {
        public List<Passenger> flightPassengers { get; set; } = new List<Passenger>();
        public Airplane airplane { get; set; }

        public Flight(Airplane airplane)
        {
            this.airplane = airplane;
        }

    }


}
