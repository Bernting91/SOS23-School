using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Uppgifter_övningar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             ////Uppgift 1
             int Nummer = 1;
            Console.WriteLine("Hello, your number is " + Nummer);
            */

            /*
           //// Uppgift 2
            int Nummer1 = 5;
            int Nummer2 = 10;
            int Nummer3 = Nummer1 + Nummer2;

            Console.WriteLine("Summering blir: " + Nummer3);
            */

            /*
            ////Uppggift 3
            byte ett = 200;
            byte två = 150;
            int tre = ett + två;
            Console.WriteLine("byte blir: " + tre);
            */

            /*
            /////Uppgift 4+5
            int age = int.MinValue;
            Console.WriteLine("Skriv in ditt namn, email, adress och ålder");
            string name = Console.ReadLine();
            string Email = Console.ReadLine();
            string Adress = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hej " + name  + Email  + Adress  + age );
            */


            /*
            ////Uppgift 6
            
            try
            {
                Console.WriteLine("Skriv två nummer");
                string nummer1 = Console.ReadLine();
                int nummer2 = int.Parse(nummer1);
                Console.WriteLine("Skriv ett till nummer");
                string nummer3 = Console.ReadLine();
                int nummer4 = int.Parse(nummer3);               
                int nummer5 = nummer2 + nummer4;
                Console.WriteLine("Total is :" + nummer2 + "+" + nummer4 + " = " + nummer5); ///Alternativ 1
                Console.WriteLine($"{nummer2} + {nummer4} = {nummer5}");  /// Alternativ 2
            }
            catch
            {
                Console.WriteLine("Skriv endast nummer");
            }
            */


            /*
           ///// Uppgift 7

            Console.WriteLine("Skriv Gorilla");           
            bool loop = true;
            while (loop == true)
            {
                string input = Console.ReadLine();
                if (input == "Gorilla")
                {
                    Console.WriteLine("duktigt");
                    loop = false;
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }
            */

            
            ////Uppgift 8

            /*
            int sparat = 5000;           
            bool loop = true;
            while (loop = true)
            {
                Console.WriteLine("Skriv in ett nummer tills du kommer över det sparade numret");
                try
                {
                    string input = Console.ReadLine();
                    int nummer = int.Parse(input);
                    while (nummer < sparat)
                    {
                        string input2 = Console.ReadLine();
                        int nummer2 = int.Parse(input2);
                        nummer = nummer + nummer2;
                        Console.WriteLine("Numret är nu " + nummer);
                    }
                    if (nummer > sparat)
                    {
                        loop = false;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Skriv endast nummer");
                }
            }
            */

            
             ////Uppgift 9
             /*
            int number = 1000;
            Console.WriteLine("The number is 1000. Would you like to subtract or add to it?");
            bool loop = true;
            while (loop = true)
            {
                                           
                string input = Console.ReadLine();
                try
                {
                    if (input == "add")
                    {
                        Console.WriteLine("How much would you like to add?");
                        string add = Console.ReadLine();
                        int antal = int.Parse(add);
                        number += antal;

                        Console.WriteLine("The number is now " + number + " Would you like to subtract or add to it?");
                    }
                    else if (input == "subtract")
                    {
                        Console.WriteLine("How much would you like to subtract?");
                        string subtract = Console.ReadLine();
                        int antal = int.Parse(subtract);
                        number -= antal;
                        Console.WriteLine("The number is now " + number + " Would you like to subtract or add to it?");
                    }

                    else if (input == "stop")
                    {
                        Console.WriteLine("Du har slutat");
                        loop = false;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Write a number");
                }

            }
           */

            /*
            ///Uppgift 10
            int[] array2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("index 2 is "+ array2[2]);
            */

            /* 
            ///Uppgift 11
            string[] array = { "Robert", "Tim", "Niklas", "karl" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Namn " + array[i]);
            }
            */

            /*
            string[] array = { "Robert", "Tim", "Niklas", "karl" };
            Console.WriteLine("Write a number between 0-4");
            for (int i = 0; i < array.Length; i++)
            {
                string number = Console.ReadLine();
                int index = int.Parse(number);
                Console.WriteLine();
            */

            /*
            Random random = new Random();
            int randomNumber = random.Next(1, 101);    
            double randomDouble = random.NextDouble();
            Console.WriteLine("Random Integer: " + randomNumber);
            Console.WriteLine("Random Double: " + randomDouble);
 
            double numberToRound = 3.75;
            double roundedNumber = Math.Round(numberToRound);
            Console.WriteLine("Original Number: " + numberToRound);
            Console.WriteLine("Rounded Number: " + roundedNumber);
            */

        }
    }

}

