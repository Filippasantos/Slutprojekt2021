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
        public override int Attack()
        {
            hitpoints = generator.Next(15, 25);
            return hitpoints;
        }
        public void BuffActive()
        {
            
        }
    }
}
