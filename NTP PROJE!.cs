using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_PROJE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Tag == "0")
            {
                Swap(pictureBox4, pictureBox5);
            }
            else  if (pictureBox3.Tag == "0")
            {
                Swap(pictureBox4, pictureBox3);
            }
            else if (pictureBox2.Tag == "0")
            {
                Swap(pictureBox4, pictureBox2);
            }
        }
        private static void Swap(PictureBox PicA, PictureBox PicB)
        {
            PictureBox PicT = new PictureBox();
            PicT.Image = PicA.Image;
            PicT.Tag = PicA.Tag;
            PicA.Image = PicB.Image;
            PicA.Tag = PicB.Tag;
            PicB.Image = PicT.Image;
            PicB.Tag = PicT.Tag;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag == "0")
            {
                Swap(pictureBox2, pictureBox1);
            }
            else if (pictureBox4.Tag == "0")
            {
                Swap(pictureBox2, pictureBox4);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag == "0")
            {
                Swap(pictureBox3, pictureBox1);
            }
            else if (pictureBox4.Tag == "0")
            {
                Swap(pictureBox3, pictureBox4);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Tag == "0")
            {
                Swap(pictureBox1, pictureBox2);
            }
            else if (pictureBox3.Tag == "0")
            {
                Swap(pictureBox1, pictureBox3);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag == "0")
            {
                Swap(pictureBox5, pictureBox4);
            }
        }
    }
}
