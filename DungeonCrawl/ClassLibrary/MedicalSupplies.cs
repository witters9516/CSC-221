using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MedicalSupplies : BaseItem
    {
        public MedicalSupplies()
        {
            ItemName = "Medical Supplies";
            ItemDescription = "This item heals the user by giving them 10 more HP.";
            HealValue = 10;
        }
    }
}
