using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            DisplayObjective(); //Set a default button to the infoLabel.
        }

        private void objectiveButton_Click(object sender, EventArgs e)
        {
            DisplayObjective(); //Display Object information
        }

        private void changingRoomsButton_Click(object sender, EventArgs e)
        {
            DisplayChangingRooms(); //Display Changing Rooms information
        }

        private void searchingForKeyItemsButton_Click(object sender, EventArgs e)
        {
            DisplaySearchingForKeyItems();  //Display Searching for Key Items information
        }

        private void battleButton_Click(object sender, EventArgs e)
        {
            DisplayBattle();    //Display Battle information.
        }

        private void usingItemsButton_Click(object sender, EventArgs e)
        {
            DisplayUsingItems();    //Display Using Item information
        }

        #region Display Information Methods
        //DisplayObjective Method
        private void DisplayObjective()
        {
            infoLabel.Text = "";
            infoLabel.Text += "Objective:\n\n";
            infoLabel.Text += "'Get to the Marathon room and defeat the enemy there.'";
        }
        //DisplayChangingRooms Method
        private void DisplayChangingRooms()
        {
            infoLabel.Text = "";
            infoLabel.Text += "Changing Rooms:\n\n";
            infoLabel.Text += "Changing Rooms is how you advance through the game.\n\n";
            infoLabel.Text += "The two directions you can go are north and south. Each time you change rooms there is a chance of running into enemies." + 
                " Some rooms require a certain item to allow you to advance to that room. Until you find that item, you will have to search for it." + 
                "\nSee 'Searching for Key Items' for more information.";
        }
        //DisplaySearchingForKeyItems Method
        private void DisplaySearchingForKeyItems()
        {
            infoLabel.Text = "";
            infoLabel.Text += "Searching for Key Items:\n\n";
            infoLabel.Text += "Some rooms in the game are blocked or locked. In order to advance to these rooms, they are certain items that must be found.\n\n";
            infoLabel.Text += "The Search button allows the player to stay in the current room. This lets the player search for the item. This can be risky because" + 
                " staying in one place can attract enemies to you. If you don't find the Key Item needed to advance, you will have to search again.";
        }
        //DisplayBattle
        private void DisplayBattle()
        {
            infoLabel.Text = "";
            infoLabel.Text += "Battle:\n\n";
            infoLabel.Text += "Battling works by Clicking the attack button beside the listBox of enemies to its right. Whenever an enemy's HP drops to zero, the enemy will "
                +"be removed from the battle.\n\nIf there are no more enemies left in the room, the north, south, and search button will be revealed.\n\n";
        }

        //DisplayUsingItems
        private void DisplayUsingItems()
        {
            infoLabel.Text = "";
            infoLabel.Text += "Using Items:\n\n";
            infoLabel.Text += "You can use items to heal yourself inside of a battle and outside of a battle. Using an item will not affect your turn in a battle."
                + "However, make sure you conserve your items as they can be rare to come by.";
        }
        #endregion
    }
}
