using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CrawlingZombieClass : BaseBattlerClass
    {
        public CrawlingZombieClass()
        {
            BattlerName = "Crawling Zombie";
            BattlerMaxHP = 15;
            BattlerCurrentHP = 15;
            Weapon = new CrawlingZombieTeethWeapon();
        }
    }
}
