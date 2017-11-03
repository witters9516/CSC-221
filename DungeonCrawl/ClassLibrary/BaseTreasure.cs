using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BaseTreasure
    {
        private string treasureName;
        private string treasureDescription;
        private string treasureUse;

        public string TreasureName
        {
            get { return treasureName; }
            set { treasureName = value; }
        }

        public string TreasureDescription
        {
            get { return treasureDescription; }
            set { treasureDescription = value; }
        }

        public string TreasureUse
        {
            get { return treasureUse; }
            set { treasureUse = value; }
        }
    }
}
