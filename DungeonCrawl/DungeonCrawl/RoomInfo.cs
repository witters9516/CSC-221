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
    public partial class RoomInfo : Form
    {
        //Globals.
        const int SIZE = 5;
        Room[] roomList = new Room[SIZE];

        struct Room
        {
            public string RoomName;
            public string RoomDescription;
            public List<BaseBattlerClass> possibleEnemies;
        };

        public RoomInfo()
        {
            InitializeComponent();
        }

        private Room CreateRoom(string rName, string rDesc)
        {
            //Create a temp struct.
            Room temp = new Room();

            //Set variables of struct.
            temp.RoomName = rName;
            temp.RoomDescription = rDesc;

            //Return temp
            return temp;
        }

        private Room SetRoomPossibleEnemies(Room room)
        {
            room.possibleEnemies = new List<BaseBattlerClass>();

            if (room.RoomName == "City Outskirts")
            {
                room.possibleEnemies.Add(new AnimalClass());
                room.possibleEnemies.Add(new EvilHumanClass());
                return room;
            }
            else if (room.RoomName == "Quickstop Station")
            {
                room.possibleEnemies.Add(new AnimalClass());
                room.possibleEnemies.Add(new EvilHumanClass());
                room.possibleEnemies.Add(new WalkingZombieClass());
                return room;

            }
            else if (room.RoomName == "Walmart")
            {
                room.possibleEnemies.Add(new EvilHumanClass());
                room.possibleEnemies.Add(new WalkingZombieClass());
                return room;

            }
            else if (room.RoomName == "Safe Zone")
            {
                room.possibleEnemies.Add(new EvilHumanClass());
                return room;
            }
            else if (room.RoomName == "Marathon")
            {
                room.possibleEnemies.Add(new WalkingZombieClass());
                room.possibleEnemies.Add(new CrawlingZombieClass());
                return room;
            }
            else
                return room;
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            //Create all the room structs.
            Room room1 = CreateRoom("City Outskirts", "The outskirts of the city. Prones to many wild animals and some humans.");
            Room room2 = CreateRoom("Quickstop Station", "An abandoned gas station that has been cleared out. Sometimes humans comeback to check. Their presense attracts the occasional zombie.");
            Room room3 = CreateRoom("Walmart", "An supermarket that can still yeild some supplies. Due to this, humans often visit which causes more zombies to appear.");
            Room room4 = CreateRoom("Safe Zone", "A safe area that contains no undead enemies. However, don't be fool because many evil humans appear in this area.");
            Room room5 = CreateRoom("Marathon", "A sprinting area where the undead are plentiful. Be careful of the crawlers as they are more powerful than they appear.");

            //Set indexes of roomList to the new structs.
            roomList[0] = room1;
            roomList[1] = room2;
            roomList[2] = room3;
            roomList[3] = room4;
            roomList[4] = room5;

            for(int i = 0; i < roomList.Length; i++)
                roomList[i] = SetRoomPossibleEnemies(roomList[i]); 

            //Add rooms to ListBox
            foreach (Room r in roomList)
                roomListBox.Items.Add(r.RoomName);

            //Set selected index to 0.
            roomListBox.SelectedIndex = 0;
        }

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            possibleEnemiesTextBox.Items.Clear();
            DisplayRoomInfo(roomList);  //Display current index
        }

        private void DisplayRoomInfo(Room[] rList)
        {
            //Set temp equal to the name of the selected index.
            string temp = roomListBox.Items[roomListBox.SelectedIndex].ToString();

            //Change display info based on the new index.
            for (int i = 0; i < rList.Length; i++)
                if (rList[i].RoomName == temp)
                {
                    roomNameLabel.Text = rList[i].RoomName;
                    roomDescriptionLabel.Text = rList[i].RoomDescription;
                    foreach (BaseBattlerClass r in rList[i].possibleEnemies)
                        possibleEnemiesTextBox.Items.Add(r.BattlerName);

                }
        }
    }
}
