using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME_CONVERTED
{
    
    public class Weapon
    {
        public string name { get; set; }
        public int dano { get; set; }
        public int preco { get; set; } = 10;
        public string rarity { get; set; }
        public int points { get; set; }
        public string colored_name { get; set; }

        //confirma se o metdo abaixo precisa retorna algo ou não?
        public void Equip_Weapon(Character player, Weapon newWeapon)
        {




        }



    }






}
