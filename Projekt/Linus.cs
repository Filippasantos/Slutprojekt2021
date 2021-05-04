using System;

namespace Projekt
{
    public class Linus : Toads
    {
        private string buff = "Venomous";
        private Random generator = new Random();

        public Linus()
        {
            SetHp(100);
            SetName("Linus");
        }
        public void BuffActive()
        {
            //hann inte
        }
    }
}
