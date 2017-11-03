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
    public partial class TreasureInfo : Form
    {
        //Globals
        public const int SIZE = 3;
        public BaseTreasure[] treasures = new BaseTreasure[SIZE];

        public TreasureInfo()
        {
            InitializeComponent();
        }

        private void TreasureInfo_Load(object sender, EventArgs e)
        {
            //Create all the BaseTreasure objects.
            BaseTreasure keyToSF = new KeyToSafeZone();
            BaseTreasure hammer = new Hammer();
            BaseTreasure flashlight = new Flashlight();

            //Set indexes of treasures to the new objects.
            treasures[0] = keyToSF;
            treasures[1] = hammer;
            treasures[2] = flashlight;

            //Add treasures to ListBox
            foreach (BaseTreasure r in treasures)
                treasureListBox.Items.Add(r.TreasureName);

            //Set selected index to 0.
            treasureListBox.SelectedIndex = 0;
        }

        private void treasureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTreasureInfo(treasures);  //Display current index
        }

        private void DisplayTreasureInfo(BaseTreasure[] rList)
        {
            //Set temp equal to the name of the selected index.
            string temp = treasureListBox.Items[treasureListBox.SelectedIndex].ToString();

            //Change display info based on the new index.
            for (int i = 0; i < rList.Length; i++)
                if (rList[i].TreasureName == temp)
                {
                    treasureNameLabel.Text = rList[i].TreasureName;
                    treasureDescriptionLabel.Text = rList[i].TreasureDescription;
                    treasureUseLabel.Text = rList[i].TreasureUse;

                }
        }
    }
}
