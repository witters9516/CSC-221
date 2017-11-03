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
    public partial class EnemyInfo : Form
    {
        //Globals
        public const int SIZE = 4;
        public BaseBattlerClass[] enemies = new BaseBattlerClass[SIZE];

        public EnemyInfo()
        {
            InitializeComponent();
        }

        private void EnemyInfo_Load(object sender, EventArgs e)
        {

            //Create all the BaseBattlerClass objects.
            BaseBattlerClass animal = new AnimalClass();
            BaseBattlerClass human = new EvilHumanClass();
            BaseBattlerClass walker = new WalkingZombieClass();
            BaseBattlerClass crawler = new CrawlingZombieClass();


            //Set indexes of enemies to the new objects.
            enemies[0] = animal;
            enemies[1] = human;
            enemies[2] = walker;
            enemies[3] = crawler;

            //Add enemies to ListBox
            foreach (BaseBattlerClass r in enemies)
                enemyListBox.Items.Add(r.BattlerName);

            //Set selected index to 0.
            enemyListBox.SelectedIndex = 0;
        }

        private void enemyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEnemyInfo(enemies);  //Display current index
        }

        private void DisplayEnemyInfo(BaseBattlerClass[] rList)
        {
            //Set temp equal to the name of the selected index.
            string temp = enemyListBox.Items[enemyListBox.SelectedIndex].ToString();

            //Change display info based on the new index.
            for (int i = 0; i < rList.Length; i++)
                if (rList[i].BattlerName == temp)
                {
                    enemyNameLabel.Text = rList[i].BattlerName;
                    enemyMaxHPLabel.Text = rList[i].BattlerMaxHP.ToString();
                    enemyCurrentHPLabel.Text = rList[i].BattlerCurrentHP.ToString();
                    enemyWeaponLabel.Text = rList[i].Weapon.WeaponName;
                    enemyWeaponDamageLabel.Text = rList[i].Weapon.WeaponDamage.ToString();
                }
        }
    }
}
