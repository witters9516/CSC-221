using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Hammer : BaseTreasure
    {
        public Hammer()
        {
            TreasureName = "Hammer";
            TreasureDescription = "A tool that can be used to break down weak walls.";
            TreasureUse = "Use this to enter the city walls.";
        }
    }
}
