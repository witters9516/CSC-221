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
    public partial class OtherInfo : Form
    {
        public OtherInfo()
        {
            InitializeComponent();
        }

        private void roomInformationButton_Click(object sender, EventArgs e)
        {
            //Create a new RoomInfo form and show it while hiding this form 
            //until the new form is canceled.
            RoomInfo temp = new RoomInfo();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }

        private void enemyInformation_Click(object sender, EventArgs e)
        {
            //Create a new RoomInfo form and show it while hiding this form 
            //until the new form is canceled.
            EnemyInfo temp = new EnemyInfo();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }

        private void itemInformationButton_Click(object sender, EventArgs e)
        {
            //Create a new RoomInfo form and show it while hiding this form 
            //until the new form is canceled.
            ItemInfo temp = new ItemInfo();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }

        private void treasureInformationButton_Click(object sender, EventArgs e)
        {
            //Create a new RoomInfo form and show it while hiding this form 
            //until the new form is canceled.
            TreasureInfo temp = new TreasureInfo();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }
    }
}
