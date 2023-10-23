using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Flygplats_Uppgift
{
    internal class AirportManager
    {
        List<Passenger> passengerList = new List<Passenger>();
        List<Airplane> airplaneList = new List<Airplane>();
        List<Flight> flightList = new List<Flight>();

        public AirportManager()
        {
            Passenger Robert = new Passenger("Robert", "Bernt@gmail.com", "112233");
            Passenger Karl = new Passenger("Karl", "Karl@gmail.com", "550011");
            Passenger Kalle = new Passenger("Kalle", "Kalle@gmail.com", "334455");
            Passenger Stefan = new Passenger("Stefan", "Stefan@gmail.com", "443300");

            Airplane LargeAirplane = new Airplane(5, "Large", "Zeus");
            Airplane MediumAirplane = new Airplane(4, "Medium", "Athena");
            Airplane SmallAirplane = new Airplane(3, "Small", "Hades");

            passengerList.Add(Robert);
            passengerList.Add(Karl);
            passengerList.Add(Kalle);
            passengerList.Add(Stefan);
            airplaneList.Add(LargeAirplane);
            airplaneList.Add(MediumAirplane);
            airplaneList.Add(SmallAirplane);
        }
        public void run()
        {

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Look at the airplanes available.");
            Console.WriteLine("2. Look at all the passengers.");
            Console.WriteLine("3. List flights");
            Console.WriteLine("4. Create flight");
            Console.WriteLine("5. TBA");
            Console.WriteLine("9. Quit");
            Console.WriteLine("-------------------------------------");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    ListAirplanes();
                    break;
                case "2":
                    ListPassenger();
                    break;
                case "3":
                    ListAirplanes();
                    break;
                case "4":
                    CreateFlight();
                    break;
                case "5":
                    ListAirplanes();
                    break;
                case "6":
                    ListPassenger();
                    break;
                default:
                    Console.WriteLine("Not an option");
                    break;

            }

        }

        private void CreateFlight()
        {
            Console.WriteLine("Pick an airplane by name.");
            ListAirplanes();
            string input = Console.ReadLine();
            foreach (Airplane airplane in airplaneList)
            {
                if (input ==)
                {
                    Flight flight = new Flight(Airplane);
                    flightList.Add(flight);

                }
            }
        }

        private void ListAirplanes()
        {
            foreach (Airplane airplane in airplaneList)
            {
                Console.WriteLine(airplane);
            }
        }
        private void ListPassenger()
        {
            foreach (Passenger Passenger in passengerList)
            {
                Console.WriteLine(Passenger);
            }
;
        }
        private void AddFlight()
        {

        }

    }
}
