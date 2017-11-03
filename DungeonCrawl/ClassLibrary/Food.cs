using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Food : BaseItem
    {
        public Food()
        {
            ItemName = "Food";
            ItemDescription = "This item heals the user by giving them 5 more HP.";
            HealValue = 5;
        }
    }
}
