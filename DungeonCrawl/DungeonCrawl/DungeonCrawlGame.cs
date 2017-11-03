using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;

namespace DungeonCrawl
{
    public partial class DungeonCrawlGame : Form
    {
        //BattleLog accumulator
        int bLCount = 0;    //If this count hits 6, run a clear function.

        //Variables
        string target = "";
        string[] rooms = { "City Outskirts", "Quickstop Station", "Walmart", "Safe Zone", "Marathon"};
        string currentRoom;
        int currentRoomIndex = 0;
        int room1Search = 0;    //(Outskirts) Need 1 to find Hammer
        int room2Search = 0;    //(Outskirts) Need 2 to find FlashLight
        int room3Search = 0;    //(Outskirts) Need 2 to find KeyToSafeZone
        int room4Search = 0;    //(Outskirts) Need 3 to find HiddenPathtoMarathon
        List<BaseBattlerClass> battlerList = new List<BaseBattlerClass>();
        public static List<BaseItem> tItems;
        public static List<BaseTreasure> tTreasures;


        //Player Object
        public BaseBattlerClass player;

        //Open Needed Scripts
        StoryTextClass storyTextClassScript = new StoryTextClass();     //Allows for storytelling
        EncounterClass encounterClassScript = new EncounterClass();     //Allows for random encounters

        public DungeonCrawlGame()
        {
            InitializeComponent();
        }

        private void DungeonCrawlGame_Load(object sender, EventArgs e)
        {
            //Load Player Object in.
            player = Form1.player;
            battlerList.Add(player);

            //Add Player Items
            AddDefaultItems(player);

            pNameLabel.Text = player.BattlerName;
            pHPLabel.Text = player.BattlerCurrentHP.ToString();

            //Handle Lists
            tItems = player.PlayerItems;
            tTreasures = player.PlayerTreasures;

            //Load in current room.
            currentRoom = rooms[currentRoomIndex];
            currentRoomLabel.Text = currentRoom;

            //Insert Beginning Part of Story
            battleLogRichTextBox.Text += storyTextClassScript.OpeningScene();
            bLCount++;
        }

        #region RoomButton Methods
        //Map Changing Functions
        private void northButton_Click(object sender, EventArgs e)
        {
            bool hammer = false;
            bool flashlight = false;
            bool keyToSZ = false;
            bool hiddenPathToMarathon = false;

            //Check BattleLog
            ClearBattleLog();

            if (currentRoomIndex == 0)
            {
                //Check for hammer
                for (int i = 0; i < player.PlayerTreasures.Count; i++)
                    if (player.PlayerTreasures[i].TreasureName == "Hammer")
                        hammer = true;
                if (hammer == true)
                {
                    currentRoom = rooms[currentRoomIndex + 1];
                    currentRoomLabel.Text = currentRoom;
                }

                //Add Encounters here

            }
            else if (currentRoomIndex == 1)
            {
                //Check for Flashlight
                for (int i = 0; i < player.PlayerTreasures.Count; i++)
                    if (player.PlayerTreasures[i].TreasureName == "Flashlight")
                        flashlight = true;
                if (flashlight == true)
                {
                    currentRoom = rooms[currentRoomIndex + 1];
                    currentRoomLabel.Text = currentRoom;
                }

                //Add Encounters here
            }
            else if (currentRoomIndex == 2)
            {
                //Check for Key To Safe Zone
                for (int i = 0; i < player.PlayerTreasures.Count; i++)
                    if (player.PlayerTreasures[i].TreasureName == "Key To Safe Zone")
                        keyToSZ = true;
                if (keyToSZ == true)
                {
                    currentRoom = rooms[currentRoomIndex + 1];
                    currentRoomLabel.Text = currentRoom;
                }

                //Add Encounters here
            }
            else if (currentRoomIndex == 3)
            {
                //Check for Key To Safe Zone
                for (int i = 0; i < player.PlayerTreasures.Count; i++)
                    if (player.PlayerTreasures[i].TreasureName == "Hidden Path to Marathon")
                        hiddenPathToMarathon = true;

                if (hiddenPathToMarathon == true)
                {
                    currentRoom = rooms[currentRoomIndex + 1];
                    currentRoomLabel.Text = currentRoom;
                }

                //Add Encounters here
            }
            else
            {
                if (bLCount != 0)
                    battleLogRichTextBox.Text += "\n\n";

                battleLogRichTextBox.Text += "\n\n You can't advance because you don't have the item to unlock the next room.";
            }
            //1. Check for Key Item that allows advancement.
            //2. if the player is holding that item, they may advance.
            //else they are told that they must search to find the item that allows access.
            //3. RandomEncounter for advancement.
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            //Check BattleLog
            ClearBattleLog();

            //No check required to go back.
            if (currentRoomIndex != 0)
            {
                currentRoom = rooms[currentRoomIndex - 1];
                currentRoomLabel.Text = currentRoom;

                //Create a new enemy to add to enemyListBox
                BaseBattlerClass tempEnemy = encounterClassScript.RandomEncounter(currentRoomLabel.Text);

                if (tempEnemy != null)
                {
                    battlerList.Add(tempEnemy);                     //Add new enemy to battlerList
                    enemyListBox.Items.Add(tempEnemy.BattlerName);  //Add new enemy to enemyListBox

                    battleLogRichTextBox.Text += " A new enemy has appeared! It's a(n) " + tempEnemy.BattlerName + ".";
                }
                else
                    battleLogRichTextBox.Text += " There is no encounter here.";
            }
            else
            {
                if (bLCount != 0)
                    battleLogRichTextBox.Text += "\n\n";
                battleLogRichTextBox.Text += "You cannot leave the outskirts of the city! You have to continue forward.";
            }
        }

        //Button Click Event that keeps the player in the same room. 
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Check BattleLog
            ClearBattleLog();

            //Display SearchText
            if (bLCount != 0)
                battleLogRichTextBox.Text += "\n\n"; 
            battleLogRichTextBox.Text += "You look around for materials or items you can use...";

            //Create a new enemy to add to enemyListBox
            BaseBattlerClass tempEnemy = encounterClassScript.RandomEncounter(currentRoomLabel.Text);

            if (tempEnemy != null)
            {
                battlerList.Add(tempEnemy);                         //Add new enemy to battlerList
                enemyListBox.Items.Add(tempEnemy.BattlerName);      //Add new enemy to enemyListBox

                battleLogRichTextBox.Text += "A new enemy has appeared! It's a(n) " + tempEnemy.BattlerName;

                //Hide the map changing buttons here (Add in after battle calculations)
                //HideRoomButtons();

                IncrementSearchCount();
            }
            else
                IncrementSearchCount();
        }

        //The HideRoomButtons method hides all of the buttons changing rooms.
        //Prevents room changing during battle.
        private void HideRoomButtons()
        {
            northButton.Hide();            //Hide North Button
            southButton.Hide();            //Hide South Button
            searchButton.Hide();            //Hide Search Button
        }

        //The ShowRoomButtons method shows all of the buttons changing rooms.
        //Allows room changing after battle.
        private void ShowSearchButtons()
        {
            northButton.Show();            //Show North Button
            southButton.Show();            //Show South Button
            searchButton.Show();            //Show Search Button
        }
        #endregion

        #region Battle Related Methods
        //Battle Target related functions
        private void attackButton_Click(object sender, EventArgs e)
        {
            //BattleFunction
                //1.Find target in list textbox.
                //2.create a copy of it and conduct damage calculation.
                //***Update Player HP.
                //3.If enemy HP = 0, remove them from the listbox.
                //4. If no enemies are in the listbox, Show all the room changing buttons.
        }

        //Button to use Item. Does not call battleFunction.
        private void itemButton_Click(object sender, EventArgs e)
        {
            //This could be having an issue with the creation of the character.
            //This was added after the player was made so they dont have the item.
            UseItem temp = new UseItem();               //Create a UseItem Form
            temp.currentItems = player.PlayerItems;     //Set the form's currentItems List to the player's itemList
            temp.player = this.player;                  //Set the form's player object to this form's player object.
            this.Hide();                                //Hide this form.
            temp.ShowDialog();                          //Show the Dialog of temp.
            this.Show();                                //Show this Form
            player.PlayerItems = tItems;                //Update itemList

            //Find player in BattleList and set it to this player.
            for (int i = 0; i < battlerList.Count; i++)
                if (battlerList[i].BattlerName == this.player.BattlerName)
                    battlerList[i] = this.player;
        }

        //Change Battle target to search for.
        private void enemyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            target = enemyListBox.Items[enemyListBox.SelectedIndex].ToString();
        }
        #endregion

        #region Other Information Methods
        private void instructionsButton_Click(object sender, EventArgs e)
        {
            //Load Instructions form.
            Instructions temp = new Instructions();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }

        private void displayItemsButton_Click(object sender, EventArgs e)
        {
            CurrentItems temp = new CurrentItems();
            this.Hide();
            temp.ShowDialog();
            this.Show();
            //Load a form with list of current items.
            //Set form list to list of current items.
        }

        private void displayKeyItemsButton_Click(object sender, EventArgs e)
        {
            CurrentKeyItems temp = new CurrentKeyItems();
            this.Hide();
            temp.ShowDialog();
            this.Show();
            //Load a form with list of current key items.
            //Set form list to list of current key items.
        }
        #endregion

        //The ClearBattleLog method clears the battleLogTextLabel.
        private void ClearBattleLog()
        {
            if (bLCount == 5)
            {
                battleLogRichTextBox.Text = "";
                bLCount = 0;
            }
            else
                bLCount++;
        }

        #region Searching Functions
        //The IncrementSearchCount method increments the current room search counter.
        //next it calls the DisplayFoundTreasures method.
        private void IncrementSearchCount()
        {
            //Increment Search count for the current room.
            if (currentRoom == rooms[0])
                room1Search++;
            else if (currentRoom == rooms[1])
                room2Search++;
            else if (currentRoom == rooms[2])
                room3Search++;
            else if (currentRoom == rooms[3])
                room4Search++;

            DisplayFoundTreasures();    //Determine if anything was found.
        }

        

        //The DisplayFoundTreasures method determines and displays whether the player finds anything during searches.
        private void DisplayFoundTreasures()
        {
            if (currentRoom == rooms[0])
                if (room1Search == 1)
                {
                    battleLogRichTextBox.Text += storyTextClassScript.FoundHammer(); //Display that you found the hammer
                    player.PlayerTreasures.Add(new Hammer());                        //Add treasure to inventory
                }
                else
                    battleLogRichTextBox.Text += storyTextClassScript.NothingOfValue();   //Found Nothing
            else if (currentRoom == rooms[1])
                if (room2Search == 2)
                {
                    battleLogRichTextBox.Text += storyTextClassScript.FoundFlashlight(); //Display that you found the flashlight
                    player.PlayerTreasures.Add(new Flashlight());                        //Add treasure to inventory
                }
                else
                    battleLogRichTextBox.Text += storyTextClassScript.NothingOfValue();   //Found Nothing
            else if (currentRoom == rooms[2])
                if (room3Search == 2)
                {
                    battleLogRichTextBox.Text += storyTextClassScript.FoundKeyToSafeZone(); //Display that you found the key to the safe zone
                    player.PlayerTreasures.Add(new KeyToSafeZone());                        //Add treasure to inventory
                }
                else
                    battleLogRichTextBox.Text += storyTextClassScript.NothingOfValue();   //Found Nothing
            else if (currentRoom == rooms[3])
                if (room4Search == 3)
                {
                    battleLogRichTextBox.Text += storyTextClassScript.FoundHiddenPathToMarathon(); //Display that you found the hidden path to the marathon.
                    player.PlayerTreasures.Add(new HiddenPathToMarathon());                        //Add treasure to inventory
                }
                else
                    battleLogRichTextBox.Text += storyTextClassScript.NothingOfValue();   //Found Nothing
            else
                battleLogRichTextBox.Text += storyTextClassScript.NothingOfValue();   //Found Nothing
        }
        #endregion

        public void AddDefaultItems(BaseBattlerClass obj)
        {
            //Add default inventory
            for (int i = 0; i < 5; i++) //Add 5 Food items
                obj.PlayerItems.Add(new Food());
            for (int i = 0; i < 3; i++) //Add 3 Medical Supply items
                obj.PlayerItems.Add(new MedicalSupplies());
            for (int i = 0; i < 1; i++) //Add 1 Clothing item
                obj.PlayerItems.Add(new Clothes());
        }
    }
}
