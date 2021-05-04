using System;

namespace Projekt
{
    public class Affe : Toads
    {
        private string buff = "Speedy";
        private Random generator = new Random();

        public Affe()
        {
            SetHp(75);
            SetName("Affe");
        }
        public void BuffActive()
        {
            //hann inte
        }
    }
}
