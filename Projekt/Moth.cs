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
        public int Attack(int hitP)
        {
            hitP = generator.Next(5, 15);
            System.Console.WriteLine("The dusty wings doesn't do much damage..");
            Console.ReadLine();
            return hitpoints;
        }
        public void BuffActive()
        {
            
        }
        public override void Buff()
        {
            
        }
    }
}
