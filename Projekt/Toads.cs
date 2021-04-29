using System;

namespace Projekt
{
    public class Toads
    {
        private int hp;
        private int hitpoints;
        private Random generator = new Random();

        protected void SetHp(int newHp)
        {
            hp = newHp;
        }
        public int GetHp()
        {
            return hp;
        }
        public int AttackEnemy(int hitP)
        {
            hitP = generator.Next(5, 25);
            return hitpoints;
        }
    }
}
