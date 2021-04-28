using System;

namespace Projekt
{
    public class Toads
    {
        private int hp = 100;
        private string name;

        protected void SetHp(int newHp)
        {
            hp = newHp;
        }
        public int GetHp()
        {
            return hp;
        }
    }
}
