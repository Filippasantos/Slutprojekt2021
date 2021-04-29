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

            Random generator = new Random();

            System.Console.WriteLine("Welcome to Toad Fighter!");
            System.Console.WriteLine("[Press ENTER to continue]");
            Console.ReadLine();
            Console.Clear();

            Character player = new Character();

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

            System.Console.WriteLine("What should your fighters name be?");
            player.SetName(Console.ReadLine());

            System.Console.WriteLine(player.GetName() + ".. The name of a mighty warrior.");
            System.Console.WriteLine("[Press ENTER to continue]");
            Console.ReadLine();
            Console.Clear();

            //fighting part

            System.Console.WriteLine("It's time..");
            System.Console.WriteLine("TO FIGHT!");
            System.Console.WriteLine("[Press ENTER to continue]");

            Toads fighter = toadsArray[generator.Next(toadsArray.Length)];

            System.Console.WriteLine(fighter.GetName());
            Console.ReadLine();
            System.Console.WriteLine(player.GetName() + " begins!");
            System.Console.WriteLine(player.GetName() + " has " + player.GetHp() + " hp!");
            System.Console.WriteLine(fighter.GetName() + " has " + fighter.GetHp() + " hp!");
            System.Console.WriteLine("[Press ENTER to continue]");
            Console.ReadLine();
            Console.Clear();

            int fighterDamage;
            int playerDamage;
            string game = "notOver";

            while (player.GetHp() > 0 && fighter.GetHp() > 0)
            {
                playerDamage = player.Attack();
                fighter.SetHp(fighter.GetHp() - playerDamage);
                System.Console.WriteLine(player.GetName() + " does " + playerDamage + " damage!");
                System.Console.WriteLine(fighter.GetName() + " now has " + fighter.GetHp() + " health left!");
                Console.ReadLine();

                fighterDamage = fighter.AttackEnemy();
                player.SetHp(player.GetHp() - fighterDamage);
                System.Console.WriteLine(fighter.GetName() + " does " + fighterDamage + " damage!");
                System.Console.WriteLine(player.GetName() + " now has " + player.GetHp() + " health left!");
                Console.ReadLine();

                Console.Clear();
            }

            if (fighter.GetHp() == 0 || fighter.GetHp() < 0)
                {
                    System.Console.WriteLine("Congrats!");
                    System.Console.WriteLine(player.GetName() + " wins!");
                    System.Console.WriteLine("[Press ENTER to close]");
                    Console.ReadLine();
                }
                else if (player.GetHp() == 0 || player.GetHp() < 0)
                {
                    System.Console.WriteLine("You lose!");
                    System.Console.WriteLine(fighter.GetName() + " wins!");
                    System.Console.WriteLine("[Press ENTER to close]");
                    Console.ReadLine();
                }
        }
    }
}
