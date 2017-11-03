using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SwordWeapon : BaseWeapon
    {
        public SwordWeapon()
        {
            WeaponName = "Sword";
            WeaponDescription = "A strong weapon for killing zombies. Easy to wield and really sharp.";
            WeaponDamage = 10;
        }
    }
}
