using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BaseBattlerClass
    {
        private string battlerName;
        private string battlerPassword;
        private int battlerMaxHP;
        private int battlerCurrentHP;
        private BaseWeapon weapon;
        private List<BaseItem> playerItems = new List<BaseItem>();
        private List<BaseTreasure> playerTreasures = new List<BaseTreasure>(); 

        public string BattlerName
        {
            get { return battlerName; }
            set { battlerName = value; }
        }

        public string BattlerPassword
        {
            get { return battlerPassword; }
            set { battlerPassword = value; }
        }

        public int BattlerMaxHP
        {
            get { return battlerMaxHP; }
            set { battlerMaxHP = value; }
        }

        public int BattlerCurrentHP
        {
            get { return battlerCurrentHP; }
            set { battlerCurrentHP = value; }
        }

        public BaseWeapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public List<BaseItem> PlayerItems
        {
            get { return playerItems; }
            set { playerItems = value; }
        }

        public List<BaseTreasure> PlayerTreasures
        {
            get { return playerTreasures; }
            set { playerTreasures = value; }
        }
    }
}
