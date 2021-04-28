using System;

namespace Projekt
{
    public class Fly : Character
    {
        private Random generator = new Random();
        private int hitpoints;

        public Fly()
        {
            SetHp(100);
            SetBuff("Clumsy");
        }
        public int Attack(int hitP)
        {
            hitP = generator.Next(15, 25);
            System.Console.WriteLine("It is clumsy, but does some damage..");
            Console.ReadLine();
            return hitpoints;
        }
        public void BuffActive()
        {
            
        }
    }
}
