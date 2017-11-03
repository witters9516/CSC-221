using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AnimalClass : BaseBattlerClass
    {
        public AnimalClass()
        {
            BattlerName = "Wild Animal";
            BattlerMaxHP = 3;
            BattlerCurrentHP = 3;
            Weapon = new ClawWeapon();
        }
    }
}
