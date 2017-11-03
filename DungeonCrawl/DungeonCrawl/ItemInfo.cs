using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace DungeonCrawl
{
    public partial class ItemInfo : Form
    {
        //Globals
        public const int SIZE = 3;
        public BaseItem[] items = new BaseItem[SIZE];

        public ItemInfo()
        {
            InitializeComponent();
        }

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            //Create all the BaseItem Objects.
            BaseItem food = new Food();
            BaseItem medSupplies = new MedicalSupplies();
            BaseItem clothes = new Clothes();


            //Set indexes of items to the new objects.
            items[0] = food;
            items[1] = medSupplies;
            items[2] = clothes;

            //Add items to ListBox
            foreach (BaseItem r in items)
                itemListBox.Items.Add(r.ItemName);

            //Set selected index to 0.
            itemListBox.SelectedIndex = 0;
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayItemInfo(items);  //Display current index
        }

        private void DisplayItemInfo(BaseItem[] rList)
        {
            //Set temp equal to the name of the selected index.
            string temp = itemListBox.Items[itemListBox.SelectedIndex].ToString();

            //Change display info based on the new index.
            for (int i = 0; i < rList.Length; i++)
                if (rList[i].ItemName == temp)
                {
                    itemNameLabel.Text = rList[i].ItemName;
                    itemDescriptionLabel.Text = rList[i].ItemDescription;
                    healValueLabel.Text = rList[i].HealValue.ToString();
                }
        }
    }
}
