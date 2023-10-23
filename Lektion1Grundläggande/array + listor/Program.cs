using System.Reflection.Metadata;

namespace array___listor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uppgift 1+2
            /*
            int[] intarray1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("index " + intarray1[2]);
            Console.WriteLine("index " + intarray1[0]);

            //Uppgift 3
            String[] stringarray = { "Sofia", "Robert", "Frans" };
            for (int i = 0; i < stringarray.Length; i++)
            {
                Console.WriteLine(stringarray[i]);
            }
            */
            //uppgift 4
            /*
            int input = int.Parse(Console.ReadLine());
            if (input >= 0 && input < stringarray.Length)
            {
                Console.WriteLine(stringarray[input]);
            }
            */
            //uppgift 5
            /*

            int total = 0;
            foreach (int number in intarray1)
            {
                total += number;
            }
            Console.WriteLine("all numbers summed is " + total);
            */
            //uppgift 6
            /*
            bool loop = false;

            while (loop == false)
            {
                string input2 = Console.ReadLine();
                for (int i = 0; i < stringarray.Length; i++)
                 {
                    if (input2 == stringarray[i])
                    {
                        Console.WriteLine("We found ! " + stringarray[i] + " He's at index " + i);
                        loop = true;
                        break;
                        continue;
                    }
                  }
            }

                foreach (string name in stringarray)
            {
                Console.WriteLine("We found " + name);

            }
            */
            int[] intarray = { 1, 2, 3, 4, 5, 6, 7, 8,};

            bool loop = false;

            while (loop = false;)
            {
                foreach (int i in intarray)
                {
                    Console.WriteLine("Values in list: " + i);
                }


            }

        }
    }
}