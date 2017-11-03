using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GunWeapon : BaseWeapon
    {
        public GunWeapon()
        {
            WeaponName = "Gun";
            WeaponDescription = "A very strong weapon for killing zombies. Easy to wield and allows powerful hits.";
            WeaponDamage = 15;
        }
    }
}
