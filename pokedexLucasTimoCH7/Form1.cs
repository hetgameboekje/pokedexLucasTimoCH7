using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedexLucasTimoCH7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(new UserControl1());
            pictureBox1.Left = 10;
            pictureBox2.Left = -100;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new UserControl2());
            pictureBox1.Left -= 110;
            pictureBox2.Left += 110;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new UserControl1());
            pictureBox2.Left -= 110;
            pictureBox1.Left += 110;
        }
    }
}
