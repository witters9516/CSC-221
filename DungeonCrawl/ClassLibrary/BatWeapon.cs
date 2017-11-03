using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BatWeapon : BaseWeapon
    {
        public BatWeapon()
        {
            WeaponName = "Bat";
            WeaponDescription = "A weapon carried by humans to help survive against other humans.";
            WeaponDamage = 2;
        }
    }
}
