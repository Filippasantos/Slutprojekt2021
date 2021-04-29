using System;

namespace Projekt
{
    public class Toads
    {
        private int hp;
        private int hitpoints;
        private string name;
        private Random generator = new Random();

        public void SetHp(int newHp)
        {
            hp = newHp;
        }
        public int GetHp()
        {
            return hp;
        }
        public void SetName(string enemyName)
        {
            name = enemyName;
        }
        public string GetName()
        {
            return name;
        }
        public int AttackEnemy()
        {
            hitpoints = generator.Next(5, 25);
            return hitpoints;
        }
    }
}
