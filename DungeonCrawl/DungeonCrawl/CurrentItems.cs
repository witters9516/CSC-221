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
    public partial class CurrentItems : Form
    {
        //Variables
        public List<BaseItem> currentItems;

        int index;

        public CurrentItems()
        {
            InitializeComponent();
        }

        private void CurrentItems_Load(object sender, EventArgs e)
        {
            index = currentItemsListBox.SelectedIndex;

            foreach (BaseItem i in currentItems)
                currentItemsListBox.Items.Add(i.ItemName);
        }

        private void currentItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = currentItemsListBox.SelectedIndex;  //Set current index of currentItemsListBox
            DisplayItemInfo();
        }

        private void DisplayItemInfo()
        {
            //Set temp equal to the name of the selected index.
            string temp = currentItemsListBox.Items[currentItemsListBox.SelectedIndex].ToString();

            //Change display info based on the new index.
            for (int i = 0; i < currentItems.Count; i++)
                if (currentItems[i].ItemName == temp)
                {
                    itemNameLabel.Text = currentItems[i].ItemName;
                    itemDescriptionLabel.Text = currentItems[i].ItemDescription;
                    healValueLabel.Text = currentItems[i].HealValue.ToString();
                }
        }
    }
}
