namespace Lektion2
{
    internal class Program
    {
        static void Main(string[] args)
        {   // uppgift 1
            Console.WriteLine("Nämn rätt primat");
            bool loop = true;
            while (loop == true)
            {
                string input = Console.ReadLine();
                if (input == "Gorilla")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Du skrev inte rätt");
                }
            }

            //Uppgift 2 +3
            int numberToReach = 500;
            int currentNumber = 0;
            while (currentNumber < numberToReach)
            {
                Console.WriteLine("Write a number");
                String inputstring = Console.ReadLine();
                try
                {
                    int nummer1 = int.Parse(inputstring);
                    currentNumber += nummer1;
                    Console.WriteLine("total is " + currentNumber);
                }
                catch
                {
                    Console.WriteLine("Please write numbers. ");
                }
            }
            Console.WriteLine("Your total overcame " + numberToReach);

            //Uppgift 4
            int number = 300;
            while (true)
            {
                Console.WriteLine("Add, subtract or end?");
                string input = Console.ReadLine().ToLower();
                if (input == "Add")
                {

                }
                else if (input == "Subtract")
                {

                }
                else if (input == "end")
                {

                }
                else
                {
                    Console.WriteLine("That wasnt an option");
                }
             
                }
            }

        }

    }
}