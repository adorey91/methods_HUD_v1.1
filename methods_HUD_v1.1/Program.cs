using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace methods_HUD_v1._1
{
    internal class Program
    {
        public string game = "Method_HUD_v1.1";
        public string playerName;
        public float score = 0f;
        public int health = 100;
        public int lives = 3;
        float multiplier = 0f;
        string playerInput;

        public void ShowHUD()
        {
            Console.WriteLine("Game Name: " + game);
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Score: " + score + "| " + "Health: " + health + "| " + "Lives: " + lives + "| " + "Multiplier: " + multiplier);
            Console.WriteLine("");

        }

        static void Main(string[] args)
        {
            ShowHUD();

            Console.WriteLine("Enter Name: ");
            playerName = Console.ReadLine();


        }

        
    }
}
