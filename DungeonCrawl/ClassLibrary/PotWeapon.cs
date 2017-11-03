using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PotWeapon : BaseWeapon
    {
        public PotWeapon()
        {
            WeaponName = "Pot";
            WeaponDescription = "A relatively weak weapon for killing zombies. A nice challenge though.";
            WeaponDamage = 1;
        }
    }
}
