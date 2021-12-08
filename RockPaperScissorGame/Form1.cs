using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissorGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clearing the images
            computerpicturebox.Image = null;
            PlayerPictureBox.Image = null;
            panelPlayer.BackColor = Color.LightGray;
            panelComputer.BackColor = Color.LightGray;
            winnerLabel.Text = "................";
            listBox1.Items.Clear();
        }

        private void rockPicturebox_Click(object sender, EventArgs e)
        {
            Random oRandomGenerator = new Random();
            panelPlayer.BackColor = Color.Cornsilk;
            panelComputer.BackColor = Color.Cornsilk;
            int iComputerChoice;

            PlayerPictureBox.Image = rockPicturebox.Image;

            int iRandomNum = oRandomGenerator.Next(100, 4000);
            iComputerChoice = (iRandomNum % 3) + 1;

            switch (iComputerChoice)
            {
                case 1:

                    computerpicturebox.Image = rockPicturebox.Image;
                    winnerLabel.Text = "VIIK";
                    listBox1.Items.Add("VIIK");
                    break;

                case 2:

                    computerpicturebox.Image = paperPicturebox.Image;
                    winnerLabel.Text = " Arvuti võidab, sest kivi lõhub käärid ";
                    panelComputer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Võitis arvuti");
                    break;

                case 3:

                    computerpicturebox.Image = scissorsPictureBox.Image;
                    winnerLabel.Text = "  ";
                    panelPlayer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Võitis arvuti");
                    break;
            }
        }

        private void paperPicturebox_Click(object sender, EventArgs e)
        {
            Random oRandomGenerator = new Random();
            panelPlayer.BackColor = Color.Cornsilk;
            panelComputer.BackColor = Color.Cornsilk;
            int iComputerChoice;

            PlayerPictureBox.Image = paperPicturebox.Image;

            int iRandomNum = oRandomGenerator.Next(100, 4000);
            iComputerChoice = (iRandomNum % 3) + 1;

            switch (iComputerChoice)
            {

                case 1:

                    computerpicturebox.Image = rockPicturebox.Image;
                    winnerLabel.Text = " Sina võidad, sest käärid lõikavad paberit ";
                    panelPlayer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Sina võidab");
                    break;

                case 2:

                    computerpicturebox.Image = paperPicturebox.Image;
                    winnerLabel.Text = "VIIK";
                    listBox1.Items.Add("VIIK");
                    break;

                case 3:

                    computerpicturebox.Image = scissorsPictureBox.Image;
                    winnerLabel.Text = " Arvuti võidab, sest kivi lõhub käärid ";
                    panelComputer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Võitis arvuti");
                    break;

            }

        }

        private void scissorsPictureBox_Click(object sender, EventArgs e)
        {
            Random oRandomGenerator = new Random();
            panelPlayer.BackColor = Color.Cornsilk;
            panelComputer.BackColor = Color.Cornsilk;
            int iComputerChoice;

            PlayerPictureBox.Image = scissorsPictureBox.Image;

            int iRandomNum = oRandomGenerator.Next(100, 4000);
            iComputerChoice = (iRandomNum % 3) + 1;

            switch (iComputerChoice)
            {

                case 1:

                    computerpicturebox.Image = rockPicturebox.Image;
                    winnerLabel.Text = " Arvuti võidab, sest kivi lõhub käärid ";
                    panelComputer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Võitis arvuti");
                    break;

                case 2:

                    computerpicturebox.Image = paperPicturebox.Image;
                    winnerLabel.Text = " Sina võidad, sest käärid lõikavad paberit ";
                    panelPlayer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Sina võidad");
                    break;

                case 3:

                    computerpicturebox.Image = scissorsPictureBox.Image;
                    winnerLabel.Text = "VIIK";
                    listBox1.Items.Add("VIIK");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            helpScreen1 help = new helpScreen1();
            help.Show();
        }
    }
}
