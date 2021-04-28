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
        }
        public int Attack()
        {
            return hitpoints;
        }
        public void BuffActive()
        {
            
        }
    }
}
