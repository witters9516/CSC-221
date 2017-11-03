using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PlayerClass : BaseBattlerClass
    {
        public PlayerClass()
        {
            BattlerName = "";
            BattlerPassword = "";
            BattlerMaxHP = 20;
            BattlerCurrentHP = 20;
            Weapon = new PotWeapon();
        }

        public PlayerClass(string name, string password, BaseWeapon weapon)
        {
            BattlerName = name;
            BattlerPassword = password;
            BattlerMaxHP = 20;
            BattlerCurrentHP = 20;
            Weapon = weapon;
        }

        
    }
}
