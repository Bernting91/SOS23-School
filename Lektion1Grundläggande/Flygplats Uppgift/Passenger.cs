using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Flygplats_Uppgift
{
    internal class Passenger
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Passenger(string name, string email, string phoneNumber)
        {
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return "Name of passenger: " + Name + ". Email of passenger: " + Email + ". Phonenumber of passenger: " + PhoneNumber;
        }
        List<Passenger> PassengerOnFlight { get; set; } = new List<Passenger>();
        
       
            
        
    }
}
