using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AxeWeapon : BaseWeapon
    {
        public AxeWeapon()
        {
            WeaponName = "Axe";
            WeaponDescription = "A weak weapon for killing zombies due to the amount of force needed to swing it.";
            WeaponDamage = 5;
        }
    }
}
