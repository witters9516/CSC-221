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
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        public bool VerifyCreatedPassword(string str)
        {
            //Variables
            bool pass1 = false; //Pass for Symbols and Punctuation
            bool pass2 = false; //Pass for UpperCase Letters
            bool pass3 = false; //Pass for LowerCase Letters
            bool pass4 = false; //Pass for numbers
            char[] passArray = str.ToCharArray();

            //Check for a symbol
            for (int i = 0; i < passArray.Length; i++)
            {
                char temp = passArray[i];
                if (char.IsPunctuation(temp) || char.IsSymbol(temp))
                    pass1 = true;
            }

            //Check for an Uppercase Letter
            for (int i = 0; i < passArray.Length; i++)
            {
                char temp = passArray[i];
                if (char.IsUpper(temp))
                    pass2 = true;
            }

            //Check for a Lowercase Letter
            for (int i = 0; i < passArray.Length; i++)
            {
                char temp = passArray[i];
                if (char.IsLower(temp))
                    pass3 = true;
            }

            //Check for a Lowercase Letter
            for (int i = 0; i < passArray.Length; i++)
            {
                char temp = passArray[i];
                if (char.IsNumber(temp))
                    pass4 = true;
            }

            //If all passes are true, return true.
            if (pass1 == true && pass2 == true && pass3 == true && pass4 == true)
            {
                MessageBox.Show("The password is valid.");
                return true;
            }
            else
            {
                //Set all passes to false.
                pass1 = false;
                pass2 = false;
                pass3 = false;
                pass4 = false;
                MessageBox.Show("The password is not valid.");
                return false;
            }
        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                string playerName = pNameTextBox.Text;
                string password = pPasswordTextBox.Text;
                BaseWeapon weapon;

                //Set playerClass
                if (potRadioButton.Checked == true)
                    weapon = new PotWeapon();
                else if (axeRadioButton.Checked == true)
                    weapon = new AxeWeapon();
                else if (swordRadioButton.Checked == true)
                    weapon = new SwordWeapon();
                else if (gunRadioButton.Checked == true)
                    weapon = new GunWeapon();
                else
                    weapon = new PotWeapon();

                //Check Password.
                bool correctPassword = VerifyCreatedPassword(password);

                
                
                //If there are no problems with the passwords, the program writes a player file.
                if (correctPassword == true)
                {
                    //Create new Player object
                    BaseBattlerClass player = new PlayerClass(playerName, password, weapon);

                    Form1.player = player;

                    string filename = player.BattlerName + ".txt";
                    StreamWriter playerFile = File.CreateText(filename);

                    playerFile.WriteLine(player.BattlerName);
                    playerFile.WriteLine(player.BattlerPassword);
                    playerFile.WriteLine(player.BattlerMaxHP.ToString());
                    playerFile.WriteLine(player.BattlerCurrentHP.ToString());
                    playerFile.WriteLine(player.Weapon.WeaponName);
                    string temp = player.Weapon.WeaponDescription.Replace(' ', ';');
                    playerFile.WriteLine(temp);
                    playerFile.WriteLine(player.Weapon.WeaponDamage.ToString());

                    playerFile.Close();
                }
                else
                {
                    //Tell player it came out wrong.
                    MessageBox.Show("The player could not be created because the password is not valid.");
                }
            }
            catch (Exception ex)
            {
                //Display error message.
                MessageBox.Show(ex.Message);
            }


            //Close this form and continue with the game.
            this.Close();
        }
    }
}
