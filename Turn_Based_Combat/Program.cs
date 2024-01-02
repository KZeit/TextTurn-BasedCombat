using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Combat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 50;
            int enemyHp = 20;
            int playerAttack = 5;
            int enemyAttack = 8;
            int healAmount = 5;

            while(playerHp > 0 && enemyHp > 0)
            {
                Console.WriteLine("\n---Player---");
                Console.WriteLine($"Player Hp: {playerHp} | Enemy HP: {enemyHp}");
                Console.WriteLine("\nPress 'A' to attack or 'H' to heal.");

                char choice = Console.ReadKey().KeyChar;

                if(choice == 'a')
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine($"\n\nPlayer attacks and deals {playerAttack} damage!");
                }
                else if(choice == 'h' && playerHp < 50)
                {
                    playerHp += healAmount;
                    Console.WriteLine($"\n\nPlayer's health restored by {healAmount}HP");
                }

                if (enemyHp > 0)
                {
                    Console.WriteLine("\n\n---Enemy---");
                    Console.WriteLine($"Enemy HP: {enemyHp} | Player Hp: {playerHp}");

                    Random random = new Random();

                    int enemyChoice = random.Next(0, 2);

                    if(enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine($"\nEnemy attacks and deals {enemyAttack} damage!");
                    }
                    else if (enemyHp < 20)
                    {
                        enemyHp += healAmount;
                        Console.WriteLine($"\nEnemy's health restored by {healAmount}HP");
                    }
                }
            }

            if (playerHp > 0 && enemyHp <= 0)
            {
                Console.WriteLine("\nPlayer Wins!");
            }
            else
            {
                Console.WriteLine("\nEnemy Wins!");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
