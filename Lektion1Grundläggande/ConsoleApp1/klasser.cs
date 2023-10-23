using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3_klasser
{
    public class klasser
    {

        //Övning 1

        public string Person = null;
        public string name;
        public int age;
        public string adress;

        public klasser(string name, int age, string adress)
        {

            this.name = name;
            this.age = age;
            this.adress = adress;
        }

        public klasser()
        {
            name = "Tim";
            age = 30;
            adress = "Kville";
        }

        public void Personuppgifter()
        {
                Console.WriteLine("name: " + name + " " + age + " " + adress);
            
        }

        public string getInfo()
        {
            return "name: " + name + " " + age + " " + adress;
        }



        /*
        public string Username = null;
        public string email;
        public int years_active;

        public klasser(string email, int years_active)
        {
            this.email = email;
            this.years_active = years_active;
        }
        public klasser()
        {
            email = "tim@mailovich.com";
            years_active = 7;
        }

        public void Yearspassed()
        {
            years_active++;
        }

        public int GetFour()
        {
            return 4;
        }
        */



    }
}
