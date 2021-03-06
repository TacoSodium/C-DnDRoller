using System;
using System.Collections.Generic;
using System.Runtime;

namespace DnDRoller
{
    public class Player
    {
        public string Name;
        public List<Die> Dice;

        public Player()
        {
            this.Name = "Player";
            this.Dice = new List<Die>();
        }

        public Player(string name, List<Die> dice)
        {
            this.Name = name;
            this.Dice = dice;
        }

        /// Rolls a specified die from the Dice List
        /// indexing starts at 0
        public int RollDie(int dieIndex)
        {
            int roll = -1;

            if (dieIndex > 0 && dieIndex < this.Dice.Count)
            {
                roll = this.Dice[dieIndex].Roll();
            }

            return roll;
        }

        /// Roll all of player's dice once and return total
        public int RollAllDice()
        {
            int rollTotal = 0;

            foreach (var die in this.Dice)
            {
                rollTotal += die.Roll();
            }

            return rollTotal;
        }

        public void AddNewDie(int numOfSides)
        {
            Die newDie = new Die(numOfSides);

            this.Dice.Add(newDie);
        }
    }
}