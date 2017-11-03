using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WalkingZombieClass : BaseBattlerClass
    {
        public WalkingZombieClass()
        {
            BattlerName = "Walking Zombie";
            BattlerMaxHP = 10;
            BattlerCurrentHP = 10;
            Weapon = new WalkingZombieTeethWeapon();
        }
    }
}
