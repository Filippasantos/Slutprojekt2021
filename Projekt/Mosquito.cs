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
        public override int Attack()
        {
            hitpoints = generator.Next(15, 25);
            return hitpoints;
        }
        public void BuffActive()
        {
            //hann inte
        }
    }
}
