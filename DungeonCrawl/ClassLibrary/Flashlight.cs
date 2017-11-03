using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Flashlight : BaseTreasure
    {
        public Flashlight()
        {
            TreasureName = "Flashlight";
            TreasureDescription = "An item that can light dark areas and make it easier to see.";
            TreasureUse = "Use to see your way through walmart";
        }
    }
}
