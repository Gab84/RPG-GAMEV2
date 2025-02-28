using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME_CONVERTED
{
    public class Character
    {
            public string Name { get; set; }
            public static int Level { get; set; } = 1;
            public int HP { get; set; } = 100;
            public int Exp { get; set; } = 0;
            public int AttackPower { get; set; } = 10;
            public double HeavyAttackMultiplier { get; set; } = 1.5;
            private static Random random = new Random();
            public Weapon Equiped_weapon { get; set; }
            
            public Character(string name)
            {
                Name = name;
            }

            public int LightAttack()
            {
                return random.Next(0, 100) < 90 ? AttackPower + Level * 2 : 0; // 90% de chance de acerto
            }

            public int HeavyAttack()
            {
                return random.Next(0, 100) < 75 ? (int)(LightAttack() * HeavyAttackMultiplier) : 0; // 75% de chance de acerto
            }

            public void GainExp(int amount)
            {
                Exp += amount;
                if (Exp >= Level * 10)
                {
                    LevelUp();
                }
            }

            public void LevelUp()
            {
                Level++;
                HP += 20;
                AttackPower += 5;
                Exp = 0;
                Console.WriteLine($"\n{Name} subiu para o nível {Level}!");
            }

            public bool IsAlive()
            {
                return HP > 0;
            }

            public void DisplayHUD()
            {
                Console.WriteLine($"\n{new string('-', 30)}");
                Console.WriteLine($"{Name} | Nível: {Level} | HP: {HP} | EXP: {Exp}/{Level * 10}");
                Console.WriteLine($"{new string('-', 30)}\n");
            }
    }
}
