using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_HUD_v1._1
{
    internal class Program
    {
        static string game = "Method_HUD_v1.1";
        static float score = 0f;
        static int health = 100;
        static int lives = 3;
        static string playerInput;
        static string playerName;

        static void Main(string[] args)
        {
            
            playerName = pName();

            cleanHUD();    
            ShowHUD();

            Console.WriteLine(playerName + " walks through the forest and falls in a hole, takes 25 damage");
            TakeDamage(25);

            cleanHUD();
            ShowHUD();
            
            Console.WriteLine("Half way through the tunnel, " + playerName + " sees a dark figure that looks like it could be an enemy. They find a rock and throw it at the enemy.");
            Console.WriteLine("The dark figure quickly approaches and swallows "+playerName +" whole.");
            TakeDamage(75);

            Console.WriteLine(health+" Health Left");

            cleanHUD();
            respawn();
            ShowHUD();
            Console.WriteLine(playerName+ " spawns back at the bottom of the tunnel. They follow the same tunnel as before but this time makes it to the end without seeing the dark figure.");

            Console.WriteLine(playerName + " comes upon an orchard where they find a chest and decide to open it.");

            cleanHUD();
            ShowHUD();

            Console.WriteLine("Type " + playerName + "'s direction... map, money or both");
            Console.WriteLine("");
            playerInput = Console.ReadLine();
            playerInput = playerInput.ToLower();

          
            if (playerInput == "map")
            {
                cleanHUD();
                ShowHUD();
                Console.WriteLine("Using the map, " + playerName + " finds their way out of the orchard and back home where there's 1000$ and a pie waiting");
                Console.WriteLine("");
                score = score + (3000);
                health = health + 50;

                cleanHUD();
                ShowHUD();
                Console.WriteLine(playerName + " lives happily ever after.");
                Console.WriteLine("");
            }
            else if (playerInput == "money")
            {
                cleanHUD();
                ShowHUD();
                Console.WriteLine(playerName + " has taken the money and receives 2500 but will not find their way back home but instead builds a new home in the orchard.");
                Console.WriteLine("");
                score = score + (2500);

                cleanHUD();
                ShowHUD();
                Console.WriteLine(playerName + " lives a pretty good life.");
                Console.WriteLine("");
            }
            else if (playerInput == "both")
            {
                cleanHUD();
                ShowHUD();
                Console.WriteLine(playerName + " being gready decides to take both. The dark figure appears from no where, screams and swallows them whole once more, but this time takes all remaining lives and health.");
                Console.WriteLine("");

                health = health - health;
                score = score - 100;
                lives = lives - lives;

                cleanHUD();
                ShowHUD();
            }
            else
            {
                cleanHUD();
                ShowHUD();
                Console.WriteLine(playerName + " Dies.");
                Console.WriteLine("You didn't listen.");
                Console.WriteLine("");
                health = health - health;
                score = score - 1000;
                lives = lives - lives;

                cleanHUD();
                ShowHUD();
            }

            Console.WriteLine("Press Key to Exit");
            Console.ReadKey(true);

        }

        static void cleanHUD()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue the story");
            Console.ReadKey(true);
            Console.Clear();    
        }

        // Takes Players Name
        static string pName()
        {
            Console.WriteLine("Enter Name: ");
            return Console.ReadLine();
        }

        static void TakeDamage(int hp)
        {
            health = health - hp;
        }

        static void respawn()
        {
            health = 100;
            lives = lives - 1;
        } // respawns player, gives them -1 life and restores 100 health
           
        static void ShowHUD()
        {
            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives);
            Console.WriteLine("");

        } // Shows HUD information
    }
}
