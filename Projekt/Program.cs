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

            Character player = new Character();

            System.Console.WriteLine("What should your fighters name be?");
            player.SetName(Console.ReadLine());

            System.Console.WriteLine(player.GetName() + ".. The name of a mighty warrior.");
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
            
            Console.ReadLine();
        }
    }
}
