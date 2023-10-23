using Lektion3_klasser;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Övning 1

            klasser namn = new klasser("Robert", 25, "Plåtslagare");
            klasser namn1 = new klasser("Jonas", 28, "Kvilletorget");
            klasser namn2 = new klasser("Koffe", 105, "Östra");
            klasser namn3 = new klasser();
            Console.WriteLine(" Namn: " + namn.name + ", Age: " + namn.age + ", Adress: " + namn.adress);
            Console.WriteLine(" Namn: " + namn1.name + ", Age: " + namn1.age + ", Adress: " + namn1.adress);
            Console.WriteLine(" Namn: " + namn2.name + ", Age: " + namn2.age + ", Adress: " + namn2.adress);
            Console.WriteLine(" Namn: " + namn3.name + ", Age: " + namn3.age + ", Adress: " + namn3.adress);

            List<klasser> list = new List<klasser>() { namn, namn1, namn2, namn3 };
            for (int i = 0; list.Count > i; i++)
            {
                Console.WriteLine("All names: " + list[i].name + " " + list[i].age + " " + list[i].adress);
            }

            Console.WriteLine("Skriv rätt namn ");
            string input = Console.ReadLine();
            bool nameFound = false;
            for (int i = 0; list.Count > i; i++)
            {
                if (input == list[i].name)
                {
                    Console.WriteLine("Youve found: " + list[i].name + ", " + list[i].age + ", " + list[i].adress);
                    nameFound = true;
                    break;
                }

            }

            if (nameFound == false)
            {
                Console.WriteLine("Ingen med det namnet.");
            }


            Console.WriteLine("Vems adress vill du ändra?");
            string input1 = Console.ReadLine();
            bool nameFound1 = false;
            for (int i = 0; list.Count > i; i++)
            {
                if (input1 == list[i].name)
                {
                    Console.WriteLine("Vilken adress vill du ändra till?");
                    string input2 = Console.ReadLine();
                    list[i].adress = input2;
                    Console.WriteLine("Den nya adressen är " + list[i].adress);
                    Console.WriteLine("Du har ändrat " + list[i].name + "'s personuppgifter till följande " + list[i].name + ", " + list[i].age + ", " + list[i].adress);
                    nameFound1 = true;
                    break;
                }
            }
            if (nameFound1 == false)
            {
                Console.WriteLine("Denna person finns inte");
            }

            namn.Personuppgifter();



            /* 
             klasser test = new klasser("Robert@mail.com", 5);
             klasser test1 = new klasser();
             int value = test.GetFour();
             test1.Username = "Tim";
             test.Username = "Robert";
             Console.WriteLine("Username :" + test.Username + ", Email: " + test.email + ", Years active: " + test.years_active);
             Console.WriteLine("Username :" + test1.Username + ", Email: " + test1.email + ", Years active: " + test1.years_active);

             Console.WriteLine("Robert has been active for: " + test.years_active + " Years");
             test.Yearspassed();
             Console.WriteLine("Robert has been active for: " + test.years_active + " Years ");
             Console.WriteLine("Test av Getfour: " + value + " test");
            */




        }



    }
}