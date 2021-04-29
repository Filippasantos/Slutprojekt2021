using System;

namespace Projekt
{
    public class Jerry : Toads
    {
        private string buff = "Sticky";
        private Random generator = new Random();

        public Jerry()
        {
            SetHp(125);
            SetName("Jerry");
        }
        public void BuffActive()
        {
            
        }
    }
}
