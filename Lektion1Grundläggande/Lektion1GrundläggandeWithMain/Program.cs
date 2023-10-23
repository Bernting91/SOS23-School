using System.Runtime.InteropServices;

namespace Lektion1GrundläggandeWithMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej Världen!");
            Console.WriteLine("test test");
            int nummer = 3;
            int nummer2 = 4;
            int summering = nummer + nummer2;
            byte one = 125;
            byte two = 230;
            int three = one + two;
            Console.WriteLine("Ditt nummer är " + nummer);
            Console.WriteLine("Summering blir " + summering);
            Console.WriteLine("Byte total" + three);
            Console.WriteLine("Whats your name?");
            String ReceivedValue = Console.ReadLine();
            Console.WriteLine("Hello " + ReceivedValue + " how are you?");

            Console.WriteLine("Please add your Name, age, email and adress");
            String Name = Console.ReadLine();
            String Age = Console.ReadLine();
            String Email = Console.ReadLine();
            String Adress = Console.ReadLine();
            Console.WriteLine("Hi " + Name + ", age: " + Age + ", Email: " + Email + ", Adress: " + Adress);

            Console.WriteLine("Please write any number and I will summarize");
            String Receivednumber1 = Console.ReadLine();
            Console.WriteLine("Please write another number");
            String Receivednumber2 = Console.ReadLine();
            int Number1 = int.Parse(Receivednumber1);
            int Number2 = int.Parse(Receivednumber2);
            int Summary = Number1 + Number2;
            Console.WriteLine("Your number is " + Summary);

            


            





        }


    }
}
