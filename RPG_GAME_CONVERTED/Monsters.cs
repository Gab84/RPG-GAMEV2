using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME_CONVERTED
{
    class Enemy
    {
        public int Level { get; set; }
        public int HP { get; set; }
        public int AttackPower { get; set; }
        private static Random random = new Random();

        public Enemy(int playerLevel)
        {
            Level = playerLevel;
            HP = 50 + playerLevel * 10;
            AttackPower = 5 + playerLevel * 2;
        }

        public int Attack()
        {
            return random.Next(0, 100) < 85 ? AttackPower + random.Next(0, 6) : 0; // 85% de chance de acerto
        }

        public bool IsAlive()
        {
            return HP > 0;
        }

        public void DisplayHUD()
        {
            Console.WriteLine($"\n{new string('-', 30)}");
            Console.WriteLine($"Inimigo | Nível: {Level} | HP: {HP}");
            Console.WriteLine($"{new string('-', 30)}\n");
        }
    }
}
