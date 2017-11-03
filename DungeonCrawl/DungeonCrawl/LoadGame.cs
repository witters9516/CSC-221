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
    public partial class LoadGame : Form
    {
        public LoadGame()
        {
            InitializeComponent();
        }

        private void loadInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create string to form a file name.
                string fileName = pNameTextBox.Text + ".txt";

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
                if (strArray[1] != pPasswordTextBox.Text)
                    MessageBox.Show("You have entered an incorrect password.");
                else
                {
                    LoadedPlayerInfo temp = new LoadedPlayerInfo();
                    temp.SetFileInfo(fileName);
                    temp.ShowDialog();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
