using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClawWeapon : BaseWeapon
    {
        public ClawWeapon()
        {
            WeaponName = "Claws";
            WeaponDescription = "Sharp nails that belong to animals. They aren't that powerful, but can take their toll after a while.";
            WeaponDamage = 1;
        }
    }
}
