using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion4KlasserObjektPolyArv
{
    internal class UserInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public UserInfo(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("My name is " + Name + " and my email is: " + Email);
        }
        public string GetInfo()
        {
            return "This is " + Name + " and his email is: " + Email;
        }
    }
}
