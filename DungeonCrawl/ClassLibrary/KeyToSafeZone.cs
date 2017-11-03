using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class KeyToSafeZone : BaseTreasure
    {
        public KeyToSafeZone()
        {
            TreasureName = "Key to the Safe Zone";
            TreasureDescription = "This item unlocks the Safe Zone that is free of the undead.";
            TreasureUse = "Use to unlock 'Safe Zone' area.";
        }
    }
}
