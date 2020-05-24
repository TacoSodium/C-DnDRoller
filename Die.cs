using System;

namespace DnDRoller
{
    public class Die
    {
        public int NumOfSides;

        public Die()
        {
            this.NumOfSides = 6;
        }

        public Die(int numOfSides)
        {
            this.NumOfSides = numOfSides;
        }

        public int Roll()
        {
            Random dieRoll = new Random();
            int roll = dieRoll.Next(1, this.NumOfSides + 1);

            return roll;
        }
    }
}