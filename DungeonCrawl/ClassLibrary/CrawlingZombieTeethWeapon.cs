using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CrawlingZombieTeethWeapon : BaseWeapon
    {
        public CrawlingZombieTeethWeapon()
        {
            WeaponName = "Zombie Teeth(Crawler)";
            WeaponDescription = "Teeth that belong to crawlers. They are much sharper than regular walking zombie teeth.";
            WeaponDamage = 4;
        }
    }
}
