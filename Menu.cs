using System;
using System.Collections.Generic;

namespace DnDRoller
{
    public class Menu
    {
        Player player1;
        Player player2;

        public Menu(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name, new List<Die>());
            player2 = new Player(player2Name, new List<Die>());
        }

        public void Start()
        {
            Console.WriteLine("Welcome to DiceRoller");
            Console.WriteLine("1. Add dice to player");
            Console.WriteLine("2. Roll dice");
            Console.WriteLine("3. View player information");
            Console.Write("Selection: ");

            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    AddDiceMenu();
                    break;
                case "2":
                    RollDice();
                    break;
                case "3":
                    ViewPlayerInfo();
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection (1, 2 or 3)");
                    Start();
                    break;

            }
        }

        public void AddDiceMenu()
        {
            Console.WriteLine("Add dice to player");
            Console.Write("Choose a player: ");
            var userSelection = Console.ReadLine();

            Console.Write("Number of sides: ");
            var sideSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case "1":
                    player1.AddNewDie(sideSelection);
                    break;
                case "2":
                    player2.AddNewDie(sideSelection);
                    break;
                default:
                    Console.WriteLine("Please enter a valid player (1 or 2)");
                    AddDiceMenu();
                    break;
            }

            Start();
        }

        public void RollDice()
        {
            // counter foreach
            int i = 0;

            Console.WriteLine("Roll dice");
            Console.Write("Choose a player: ");
            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    foreach (var die in player1.Dice)
                    {
                        Console.WriteLine($"D{die.NumOfSides} = {i}");
                        i++;
                    }
                    break;
                case "2":
                    foreach (var die in player2.Dice)
                    {
                        Console.WriteLine($"D{die.NumOfSides} = {i}");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid player (1 or 2)");
                    break;

            }

            Console.Write("Choose die: ");
            int dieSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case "1":
                    if (dieSelection >= 0 && dieSelection < player1.Dice.Count)
                    {
                        Console.WriteLine($"{player1.Name} rolled {player1.RollDie(dieSelection)}");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid index");
                    }
                    break;
                case "2":
                    if (dieSelection >= 0 && dieSelection < player2.Dice.Count)
                    {
                        Console.WriteLine($"{player2.Name} rolled {player2.RollDie(dieSelection)}");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid index");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid player (1 or 2)");
                    break;
            }

            Start();
        }

        public void ViewPlayerInfo()
        {
            Console.WriteLine("View player information");
            Console.Write("Choose a player: ");
            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    Console.WriteLine($"Player 1: {player1.Name}");
                    Console.WriteLine("Dice:");
                    foreach (var die in player1.Dice)
                    {
                        Console.WriteLine(die.NumOfSides);
                    }
                    break;
                case "2":
                    Console.WriteLine($"Player 2: {player2.Name}");
                    Console.WriteLine($"Dice:");
                    foreach (var die in player2.Dice)
                    {
                        Console.WriteLine(die.NumOfSides);
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid player (1 or 2)");
                    ViewPlayerInfo();
                    break;
            }

            Start();
        }
    }
}