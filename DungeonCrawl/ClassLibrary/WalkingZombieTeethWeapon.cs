using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WalkingZombieTeethWeapon : BaseWeapon
    {
        public WalkingZombieTeethWeapon()
        {
            WeaponName = "Zombie Teeth(Walker)";
            WeaponDescription = "Teeth that belong to walking zombies. They are sharp and can take a real bite out of you.";
            WeaponDamage = 3;
        }
    }
}
