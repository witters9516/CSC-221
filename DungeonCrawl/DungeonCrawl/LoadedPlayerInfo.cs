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
    public partial class LoadedPlayerInfo : Form
    {
        string fileName;

        public LoadedPlayerInfo()
        {
            InitializeComponent();
        }

        private void LoadedPlayerInfo_Load(object sender, EventArgs e)
        {
            try
            {

                //Open a File with the created string.
                StreamReader inputFile = File.OpenText(fileName);

                //Create a string to hold all of the files contents to be split later.
                string str = "";

                //Loop to add info to the str string
                while (!inputFile.EndOfStream)
                    str += inputFile.ReadLine() + " ";

                //Create an array from splitting a string.
                string[] strArray = str.Split(null);

                //Check Password from player input to see if it is correct.
                //If the password is correct, it displays the information to the user.
                //If the password is incorrect, it says that the person has inputed the wrong password.
                for (int i = 0; i < strArray.Length; i++)
                    if (i == 0)
                        pNameLabel.Text = strArray[0];      //Display PlayerName
                    else if (i == 1)
                        pPasswordLabel.Text = strArray[1];  //Display PlayerPassword
                    else if (i == 2)
                        pMaxHPLabel.Text = strArray[2];     //Display PlayerMaxHP
                    else if (i == 3)
                        pCurrentHPLabel.Text = strArray[3]; //Display PlayerCurrentHP
                    else if (i == 4)
                        pWeaponNameLabel.Text = strArray[4];  //Display PlayerPassword
                    else if (i == 5)
                        pWeaponDescriptionLabel.Text = strArray[5].Replace(';', ' ');     //Display PlayerMaxHP
                    else if (i == 6)
                        pWeaponDamageLabel.Text = strArray[6];      //Display PlayerCurrentHP

                Form1.player = new PlayerClass();
                Form1.player.BattlerName = strArray[0];
                Form1.player.BattlerPassword = strArray[1];
                Form1.player.BattlerMaxHP = int.Parse(strArray[2]);
                Form1.player.BattlerCurrentHP = int.Parse(strArray[3]);
                Form1.player.Weapon.WeaponName = strArray[4];
                Form1.player.Weapon.WeaponDescription = strArray[5].Replace(';', ' ');
                Form1.player.Weapon.WeaponDamage = int.Parse(strArray[6]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void closeAndContinueButton_Click(object sender, EventArgs e)
        {
            //Close this Form
            this.Close();
        }


        public void SetFileInfo(string file)
        {
            fileName = file;
        }
        
    }
}
