using System;

namespace Projekt
{
    public class Moth : Character
    {
        private Random generator = new Random();
        private int hitpoints;

        public Moth()
        {
            SetHp(125);
            SetBuff("Adorable");
        }
        public override int Attack()
        {
            hitpoints = generator.Next(5, 15);
            return hitpoints;
        }
        public void BuffActive()
        {
            //hann inte
        }
    }
}
