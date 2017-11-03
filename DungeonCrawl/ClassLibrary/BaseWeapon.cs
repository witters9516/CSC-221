using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BaseWeapon
    {
        private string weaponName;
        private int weaponDamage;
        private string weaponDescription;

        public string WeaponName
        {
            get { return weaponName; }
		    set { weaponName = value; }
	    }

        public int WeaponDamage
        {
            get { return weaponDamage; }
		    set { weaponDamage = value; }
	    }

        public string WeaponDescription
        {
            get { return weaponDescription; }
		    set { weaponDescription = value; }
	    }
    }
}
