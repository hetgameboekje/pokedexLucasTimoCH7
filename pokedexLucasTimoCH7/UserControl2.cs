using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedexLucasTimoCH7
{
    public partial class UserControl2 : UserControl
    {
        public int _idPage = 0;
        public UserControl2()
        {
            InitializeComponent();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _idPage += 1;
            label1.Text = "ID = " + _idPage;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _idPage -= 1;
            label1.Text = "ID = " + _idPage;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string imageUrl = "https://i.imgur.com/iG1jyam.jpeg";
            WebClient client = new WebClient();
            byte[] imageBytes = client.DownloadData(imageUrl);
            using (MemoryStream stream = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(stream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = image;
            }


            label1.Text = "ID = " + _idPage;


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
