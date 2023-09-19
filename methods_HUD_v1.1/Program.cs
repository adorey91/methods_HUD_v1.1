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
        static float multiplier = 0f;
        static string playerInput;
        static string playerName;

        static void Main(string[] args)
        {
            
            playerName = pName();

            cleanHUD();    

            ShowHUD();

            TakeDamage(50);

            cleanHUD();

            ShowHUD();

            Console.WriteLine("Press Key to Exit");
            Console.ReadKey(true);

        }

        static void cleanHUD()
        {
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
        static void ShowHUD()
        {
            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier);
            Console.WriteLine("");

        }


    }
}
