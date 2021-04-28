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
