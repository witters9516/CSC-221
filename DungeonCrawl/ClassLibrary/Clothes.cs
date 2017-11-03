using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Clothes : BaseItem
    {
        public Clothes()
        {
            ItemName = "Clothes";
            ItemDescription = "This item heals the user by giving them 25 more HP.";
            HealValue = 25;
        }
    }
}
