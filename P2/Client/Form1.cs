using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectWCF;

namespace WinFormClient
{
    public partial class Form1 : Form
    {

        MediaPersonClient service = new MediaPersonClient();
        string addMediaType = "";
        string currentVideo = "";
        string currentImage = "";
        string lastTypeSelected = "";
        int indexCurrentImage = 0;
        int indexCurrentVideo = 0;
        string selectedFile;
        string[] searchedMedia;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            addMediaType = "photo";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            addMediaType = "video";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if(radioButton1.Checked)
            {
                lastTypeSelected = "photo";
                if (radioButton5.Checked)
                {
                    string place = textBox1.Text;
                    searchedMedia = service.GetMediaByLocation(lastTypeSelected, place.ToLower());
                    currentImage = searchedMedia[0];
                    pictureBox1.Image = new Bitmap(currentImage);
                    indexCurrentImage = 0;
                    textBox3.Text = currentImage;
                }
                else if (radioButton6.Checked)
                {
                    string person = textBox2.Text;
                    searchedMedia = service.GetMediaByPersonName(person.ToLower(),lastTypeSelected);
                    currentImage = searchedMedia[0];
                    pictureBox1.Image = new Bitmap(currentImage);
                    indexCurrentImage = 0;
                    textBox3.Text = currentImage;
                }
            }
            else if(radioButton2.Checked)
            {
                lastTypeSelected = "video";

                if (radioButton5.Checked)
                {
                    string place = textBox1.Text;
                    searchedMedia = service.GetMediaByLocation(lastTypeSelected, place.ToLower());
                    currentVideo = searchedMedia[0];
                    indexCurrentVideo = 0;
                    textBox3.Text = currentVideo;
                }
                else if (radioButton6.Checked)
                {
                    string person = textBox2.Text;
                    searchedMedia = service.GetMediaByPersonName(person.ToLower(), lastTypeSelected);
                    currentVideo = searchedMedia[0];
                    indexCurrentVideo = 0;
                    textBox3.Text = currentVideo;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int indexOfMedia = 0; indexOfMedia < searchedMedia.Length; indexOfMedia++) {
                if(String.Equals(currentImage, searchedMedia[indexOfMedia]))
                {
                    if(indexOfMedia + 1 == searchedMedia.Length && searchedMedia.Length != 1)
                    {
                        currentImage = searchedMedia[indexOfMedia - 1];
                        indexOfMedia--;
                        pictureBox1.Image = new Bitmap(currentImage);
                    }
                    else
                    {
                        currentImage = "noImage.jpg";
                        pictureBox1.Image = new Bitmap(currentImage);
                    }
                    searchedMedia = searchedMedia.Where(value => value != searchedMedia[indexOfMedia]).ToArray();
                    service.RemoveMedia(searchedMedia[indexOfMedia]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lastTypeSelected == "photo")
            {
                if(indexCurrentImage > 0)
                {
                    indexCurrentImage -= 1;
                    currentImage = searchedMedia[indexCurrentImage];
                    pictureBox1.Image = new Bitmap(currentImage);
                }
            }
            else if(lastTypeSelected == "video")
            {
                if(indexCurrentVideo > 0)
                {
                    indexCurrentVideo -= 1;
                    currentVideo = searchedMedia[indexCurrentVideo];
                    System.IO.StreamReader reader = new System.IO.StreamReader(currentVideo);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lastTypeSelected == "photo")
            {
                if (indexCurrentImage < searchedMedia.Length - 1)
                {
                    indexCurrentImage += 1;
                    currentImage = searchedMedia[indexCurrentImage];
                    pictureBox1.Image = new Bitmap(currentImage);
                }
            }
            else if (lastTypeSelected == "video")
            {
                if (indexCurrentVideo < searchedMedia.Length - 1)
                {
                    indexCurrentVideo += 1;
                    currentVideo = searchedMedia[indexCurrentVideo];
                    System.IO.StreamReader reader = new System.IO.StreamReader(currentVideo);
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
  
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(addMediaType != "" && textBox6.Text != "" && textBox5.Text !="")
            {
                service.CreateMedia(addMediaType, textBox6.Text.ToLower(), textBox5.Text.ToLower());
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedFile = FD.FileName;
                textBox5.Text = selectedFile;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(textBox5.Text);
        }
    }
}
