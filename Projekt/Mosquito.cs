using System;

namespace Projekt
{
    public class Mosquito : Character
    {
        private Random generator = new Random();
        private int hitpoints;
        public Mosquito()
        {
            SetHp(75);
            SetBuff("Annoying");
        }
        public int Attack(int hitP)
        {
            hitP = generator.Next(15, 25);
            System.Console.WriteLine("The proboscis of the mosquito stings a bit..");
            Console.ReadLine();
            return hitpoints;
        }
        public void BuffActive()
        {

        }
    }
}
