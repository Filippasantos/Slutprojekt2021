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
