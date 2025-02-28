using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME_CONVERTED
{
    internal class Programa
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome do seu personagem: ");
            string name = Console.ReadLine();
            Character player = new Character(name);

            while (player.IsAlive())
            {
                Enemy enemy = new Enemy(player.Level);
                Console.WriteLine($"\nApareceu um inimigo nível {enemy.Level} com {enemy.HP} HP!");

                while (enemy.IsAlive() && player.IsAlive())
                {
                    player.DisplayHUD();
                    enemy.DisplayHUD();
                    Console.Write("\nEscolha um ataque: (1) Leve (2) Pesado: ");
                    string action = Console.ReadLine();
                    int damage;

                    if (action == "1")
                    {
                        damage = player.LightAttack();
                    }
                    else if (action == "2")
                    {
                        damage = player.HeavyAttack();
                    }
                    else
                    {
                        Console.WriteLine("Escolha inválida!");
                        continue;
                    }

                    if (damage == 0)
                    {
                        Console.WriteLine("Você errou o ataque!");
                    }
                    else
                    {
                        enemy.HP -= damage;
                        Console.WriteLine($"Você causou {damage} de dano! Inimigo tem {enemy.HP} HP restante.");
                    }

                    if (enemy.IsAlive())
                    {
                        int enemyDamage = enemy.Attack();
                        if (enemyDamage == 0)
                        {
                            Console.WriteLine("O inimigo errou o ataque!");
                        }
                        else
                        {
                            player.HP -= enemyDamage;
                            Console.WriteLine($"O inimigo atacou e causou {enemyDamage} de dano! Você tem {player.HP} HP restante.");
                        }
                    }
                }
                if (player.IsAlive())
                {
                    int expGained = 5 + player.Level * 2;
                    Console.WriteLine($"\nVocê derrotou o inimigo e ganhou {expGained} de experiência!");
                    player.GainExp(expGained);
                }
                else
                {
                    Console.WriteLine("\nVocê foi derrotado! Fim de jogo.");
                    break;
                }
            }




        }
    }
}
