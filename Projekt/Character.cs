using System;

namespace Projekt
{
    public class Character
    {
        private int hp;
        private string name;
        private string buff;
        public void SetHp(int newHp)
        {
            hp = newHp;
        }
        public int GetHp()
        {
            return hp;
        }
        public void SetName(string username)
        {
            name = username;
        }
        public string GetName()
        {
            return name;
        }
        public void SetBuff(string buffSetter)
        {
            buff = buffSetter;
        }
        public string GetBuff()
        {
            return buff;
        }
        public void ActivateBuff()
        {
            
        }

        public virtual int Attack()
        {
            return 0;
        }
    }
}
