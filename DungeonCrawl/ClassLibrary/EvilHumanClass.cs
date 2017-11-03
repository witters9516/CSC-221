using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EvilHumanClass : BaseBattlerClass
    {
        public EvilHumanClass()
        {
            BattlerName = "Evil Human";
            BattlerMaxHP = 7;
            BattlerCurrentHP = 7;
            Weapon = new BatWeapon();
        }
    }
}
