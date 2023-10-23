using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift
{
    internal class Game
    {
        Item Sword = new Item("Sword");
        Item Bow = new Item("Bow");
        Item Wand = new Item("Wand");
        
        
        public void run()
        {
            Hero Player;
            bool quit = false;
            while (quit == false)
            {
                StartMenu();
                string input = Console.ReadLine();
                switch (input)
                {
                    
                    case "1":
                        Player = new Hero("Knight", Sword);
                        ChoiceLocation(Player);
                        break;
                    case "2":
                        Player = new Hero("Ranger", Bow);
                        ChoiceLocation(Player);
                        break;
                    case "3":
                        Player = new Hero("Wizard", Wand);
                        ChoiceLocation(Player);
                        break;
                    case "4":
                        Console.WriteLine("This isnt for you friend.");
                        break; ;
                    default:
                        Console.WriteLine("Youre not suitable for this");
                        quit = true;
                        break;
                }
            }
        }
        private void ChoiceLocation(Hero Player)
        {
            Location Lake = new Location("Lake", Wand);
            Location Cave = new Location("Cave", Bow);
            Location Armory = new Location("Armory", Sword);
            Console.WriteLine("So you're a " + Player.Type + "?");
            Console.WriteLine("Yes, I am a " + Player.Type + " with a " + Player.GetItems()[0]);
            Console.WriteLine("To defeat the dragon and save the princess you need all the weapons");
            bool locationChoice = false;
            while (locationChoice == false)
            {
                LocationSearchMenu();
                string destination = Console.ReadLine();
                switch (destination)
                {
                    case "1":
                        TravelDestination(Player, Lake);
                        break;
                    case "2":
                        TravelDestination(Player, Cave);
                        break;
                    case "3":
                        TravelDestination(Player, Armory);
                        break;
                    case "4":
                        Console.WriteLine("Bye then.");
                        locationChoice = true;
                        break;
                    case "5":
                        FaceDragon(Player);
                        locationChoice = true;
                        break;
                    default:
                        Console.WriteLine("Youre not suitable for this");
                        break;
                }
            }
        }
        private void StartMenu()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Hello adventurer. What class are you?");
            Console.WriteLine("1, A Knight with a sword for a starter?");
            Console.WriteLine("2, A Ranger with a bow for a starter?");
            Console.WriteLine("3, A Wizard with a wand for a starter?");
            Console.WriteLine("4, Im just a peasant.");
            Console.WriteLine("--------------------------------------------------------------");
        }
        private void LocationSearchMenu()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Where do you want to go and search for the items you need?");
            Console.WriteLine("1, I want to go to the lake");
            Console.WriteLine("2, I want to go to the cave");
            Console.WriteLine("3, I want to go to the armory");
            Console.WriteLine("4, I'd rather just go home.");
            Console.WriteLine("5, Im ready to face the dragon!");
            Console.WriteLine("--------------------------------------------------------------");
        }
        private bool CheckItem(Hero player, Location location)
        {
            //Check if player has location loot in inventory list
            if (player.GetItems().Contains(location.Loot))
                {
                    Console.WriteLine("You've already got " + location.Loot + ", dont be greedy.");
                    Console.WriteLine();
                    return true;
                }
            return false;
        }
        private void TravelDestination(Hero player, Location location)
        {
            //If player already has the location item, return.
            if (CheckItem(player, location))
            {
                return;
            }
            Console.WriteLine("You're at the "+ location.Hideout + ". You want to take a look around? Yes/No");
            try
            {
                String choice = Console.ReadLine();
                if (choice == "Yes")
                {
                    Console.WriteLine("You found a " + location.Loot + "!!");
                    player.AddItem(location.Loot);
                    ListItems(player);
                }
                else if (choice == "No")
                {
                    Console.WriteLine("Alright, I see.");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("You gotta write 'Yes' or 'No'");
            }
        }
        private void ListItems(Hero player)
        {
            //List all location items currently in inventory
            Console.WriteLine("You now have the following weapons:");
            for (int i = 0; i < player.GetItems().Count; i++)
            {
                Console.WriteLine(player.GetItems()[i]);
            }
        }
        private void FaceDragon(Hero player)
        {           
            if (player.GetItems().Contains(Sword) && player.GetItems().Contains(Bow) && player.GetItems().Contains(Wand))
            {
                PrintEndGameCredits();
                Random random = new Random();
                int num1 = random.Next(1, 11);
                int num2 = random.Next(1, 11);
                int correctAnswer = num1 + num2;
                Console.WriteLine("What is " + num1 +" + "+ num2 +"?");
                string userAnswer = Console.ReadLine();
                try
                {
                    int UserResponse = int.Parse(userAnswer);
                    if (UserResponse == correctAnswer)
                    {
                        Console.WriteLine("The princess accepts this answer and all is well in the land again");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("sorry, the correct answer is " + correctAnswer);
                    }
                }
                catch
                {
                    Console.WriteLine("Please write a number");
                }
            }
            else
            {
                Console.WriteLine("You need all the items to kill the dragon");
                Console.WriteLine("You died.");
                return;
            }
        }
        private void PrintEndGameCredits()
        {
            Console.WriteLine("You are ready to face the dragon hero!");
            string dragonArt = @"
                   __====-_  _-====___
             _--^^^#####//      \\#####^^^--_
          _-^##########// (    ) \\##########^-_
         -############//  |\^^/|  \\############-
       _/############//   (@::@)   \\############\_
      /#############((     \\//     ))#############\
     -###############\\    (oo)    //###############-
    -#################\\  / "" "" \\  //#################-
   -###################\\/  (   )  \/###################-
  _#/|##########/\######(   /   \   )######/\##########|\#_
 |/  |/  |/  |/  |/  |/  |/  |/  |/  |/  |/  |/  |/  |/  |/
";

            Console.WriteLine(dragonArt);
            Console.WriteLine("--------------------");
            Console.WriteLine("After a long fight you finally defeat the dragon and save the princess");
            Console.WriteLine("But your final challenge still lies ahead. The princess asks you a math question");
            Console.WriteLine("--------------------");
        }

    }
}





    
