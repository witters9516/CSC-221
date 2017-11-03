/**
* 10/21/2017
* CSC 253
* Shawn Witter, Tanisha Robertson, Dexter Wilder,  William Crockett
* This is the Dungeon Crawl Game for Part 3.
*/
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
    public partial class Form1 : Form
    {
        public static BaseBattlerClass player;

        public Form1()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            NewGame newGameForm = new NewGame();
            this.Hide();
            newGameForm.ShowDialog();
            this.Show();
            MessageBox.Show(player.BattlerName + "\n"
                + player.BattlerPassword + "\n"
                + player.BattlerMaxHP + "\n"
                + player.BattlerCurrentHP + "\n"
                + player.Weapon.WeaponName + "\n"
                + player.Weapon.WeaponDescription + "\n"
                + player.Weapon.WeaponDamage.ToString());
            DungeonCrawlGame dcgForm = new DungeonCrawlGame();
            this.Hide();
            dcgForm.ShowDialog();
            this.Show();
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            LoadGame loadGameForm = new LoadGame();
            this.Hide();
            loadGameForm.ShowDialog();
            this.Show();
            MessageBox.Show(player.BattlerName + "\n"
                + player.BattlerPassword + "\n"
                + player.BattlerMaxHP + "\n"
                + player.BattlerCurrentHP + "\n"
                + player.Weapon.WeaponName + "\n"
                + player.Weapon.WeaponDescription + "\n"
                + player.Weapon.WeaponDamage.ToString());
            DungeonCrawlGame dcgForm = new DungeonCrawlGame();
            this.Hide();
            dcgForm.ShowDialog();
            this.Show();
        }

        private void otherInfoButton_Click(object sender, EventArgs e)
        {
            OtherInfo otherInfoForm = new OtherInfo();
            this.Hide();
            otherInfoForm.ShowDialog();
            this.Show();
        }
    }
}
