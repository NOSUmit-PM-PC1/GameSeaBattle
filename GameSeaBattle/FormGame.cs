using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSeaBattle
{
    public partial class FormGame : Form
    {
        int v = 5;
        public FormGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
        }

        private void timerShip_Tick(object sender, EventArgs e)
        {
            pictureBoxShip.Left = pictureBoxShip.Left + v;
            if (pictureBoxShip.Left >= this.Width)
                v = -v;
            if (pictureBoxShip.Left < 0)
                v = -v;
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Right)
                pictureBoxTorpedo.Left += 3;
            if (e.KeyCode == Keys.Left)
                pictureBoxTorpedo.Left -= 3;
            if (e.KeyCode == Keys.Up)
                timerTorpedo.Enabled = true;
        }

        private void timerTorpedo_Tick(object sender, EventArgs e)
        {
            pictureBoxTorpedo.Top -= 10;
            if (pictureBoxSea.Top > pictureBoxTorpedo.Top)
            {
                pictureBoxTorpedo.Top = this.Height - 100;
                timerTorpedo.Enabled = false;
            }
        }
    }
}
