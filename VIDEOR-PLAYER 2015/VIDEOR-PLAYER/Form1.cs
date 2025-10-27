using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIDEOR_PLAYER
{
    public partial class PSVIDEOR : Form
    {
        public PSVIDEOR()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mp.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mp.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mp.settings.volume = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mp.settings.volume = 100;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            mp.URL = openFileDialog1.FileName;
        }

        private void mp_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
