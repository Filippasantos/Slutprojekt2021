using System;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput;
            Toads Affe = new Affe();
            Toads Jerry = new Jerry();
            Toads Linus = new Linus();
            Toads[] toadsArray = {Affe, Jerry, Linus};

            System.Console.WriteLine("Welcome to Toad Fighter!");
            System.Console.WriteLine("[Press ENTER to continue]");
            Console.ReadLine();
            Console.Clear();
            
            /*Linus toadLinus = new Linus();
            System.Console.WriteLine(toadLinus.GetHp());*/

            Character Player = new Character();
            System.Console.WriteLine("What should your fighters name be?");
            Player.SetName(Console.ReadLine());

            System.Console.WriteLine(Player.GetName() + ".. The name of a mighty warrior.");
            System.Console.WriteLine("[Press ENTER to continue]");
            Console.ReadLine();
            Console.Clear();

            System.Console.WriteLine("Choose your fighter..");
            System.Console.WriteLine("1. Mosquito");
            System.Console.WriteLine("2. Fly");
            System.Console.WriteLine("3. Moth");
            System.Console.WriteLine("[Type the number of the fighter]");
            playerInput = Console.ReadLine();

            while (playerInput != "1" && playerInput != "2" && playerInput != "3")
            {
                Console.Clear();
                System.Console.WriteLine("Error, try again..");
                System.Console.WriteLine("1. Mosquito");
                System.Console.WriteLine("2. Fly");
                System.Console.WriteLine("3. Moth");
                System.Console.WriteLine("[Type the number of the fighter]");
                playerInput = Console.ReadLine();
            }

            Console.Clear();

            Character player = new Character();

            if (playerInput == "1")
            {
                player = new Mosquito();
            }
            else if (playerInput == "2")
            {
                player = new Fly();
            }
            else if (playerInput == "3")
            {
                player = new Moth();
            }

            //casper hjälpte mig lösa problemet

            //problem uppstod, jag vet inte hur jag ska kunna skapa och skriva kod till instanser av subklasser om jag
            //inte vet vilken subklass spelaren ska använda...
            
            
            Console.ReadLine();
        }
    }
}
