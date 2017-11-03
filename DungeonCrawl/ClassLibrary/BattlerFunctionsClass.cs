using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BattlerFunctionsClass
    {
        public int BattleCalculation(BaseBattlerClass attacker, BaseBattlerClass attacked)
        {
            attacked.BattlerCurrentHP -= attacker.Weapon.WeaponDamage;
            //Display it to the rich textbox. "Attacker dealt (damage) points of damage to the attacked."
            return attacked.BattlerCurrentHP;
        }
    }
}
