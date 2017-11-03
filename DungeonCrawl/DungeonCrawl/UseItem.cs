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
    public partial class UseItem : Form
    {
        //Variables
        public BaseBattlerClass player;
        public List<BaseItem> currentItems;

        int index;

        public UseItem()
        {
            InitializeComponent();
        }

        private void UseItem_Load(object sender, EventArgs e)
        {
            foreach (BaseItem i in currentItems)
                currentItemsListBox.Items.Add(i.ItemName);

            currentItemsListBox.SelectedIndex = 0;
            index = currentItemsListBox.SelectedIndex;
        }

        private void currentItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = currentItemsListBox.SelectedIndex;  //Set current index of currentItemsListBox
            DisplayItemInfo();
        }

        private void useItemButton_Click(object sender, EventArgs e)
        {
            BaseItem temp = null;

            for (int i = 0; i < currentItems.Count; i++)
                if (currentItemsListBox.Items[currentItemsListBox.SelectedIndex].ToString() == currentItems[i].ItemName)
                    temp = currentItems[i];

            if (temp != null)
                UseItemOnPlayer(temp, player);
            else
                MessageBox.Show("You have all the trasure you need out of this room.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        //The UseItemOnPlayer method accepts a BaseItem and a BaseBattlerClass object as an argument.
        //This function uses the item to heal the player and then removes the item from the list and listbox.
        private void UseItemOnPlayer(BaseItem item, BaseBattlerClass battler)
        {
            if (currentItemsListBox.Items.Count != 0)
            {
                //Item found?
                bool itemFound = false;

                //Remove that item from the list
                //currentItemsListBox.Items.RemoveAt(currentItemsListBox.SelectedIndex);

                //Find item used in the standard list and remove it.
                for (int i = 0; i < currentItems.Count; i++)
                {
                    if (itemFound == false)
                        if (item.ItemName == currentItems[i].ItemName)
                            currentItems.RemoveAt(i);
                    itemFound = true;
                }

                //Heal Player
                player.BattlerCurrentHP += item.HealValue;

                //Handle battlerHP that is over it's Max Value
                if (player.BattlerCurrentHP >= player.BattlerMaxHP)
                    player.BattlerCurrentHP = player.BattlerMaxHP;

                //Set list in main game to the new list.
                DungeonCrawlGame.tItems = currentItems;

                this.Close();
            }
            else
            {
                MessageBox.Show("There are no items to use.");
            }

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
            //index = currentItemsListBox.SelectedIndex;  //Set current index of currentItemsListBox

        }
    }
}
