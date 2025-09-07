
//Rock Paper Scissors Game 
//Nitya Patel


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;  //For playing sound 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Rock_Paper_Scissors
{


    public partial class frmRPS : Form
    {
        private int compSco = 0; //computer score
        private int playSco = 0; //player score 
        private int tie = 0; //tie count
        private string player; //player name
        public frmRPS()
        {
            InitializeComponent();
        }

        private void frmRPS_Load(object sender, EventArgs e)
        {
            inti(); //Intialize game
            btnPlay.Focus();//set focuas to play button
            

        }
        private void inti()
        {
            getInfo(); //Ask for player name 
        }
        private void getInfo()
        {
            player = Interaction.InputBox("Enter Name:", "Rock,Paper,Scissors SHOOT...", "PLayer", 500, 500);
            lblName.Text = "Choose one" + " " + player;
            lblLPlaysco.Text = player;
        }   

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //player computer
            Random rand = new Random();
            int comp;

            comp = rand.Next(3) + 1;

            //if player chose rock
            if (rdbRock.Checked)
            {
                picUse.Image = Properties.Resources.rock2;

                
                //rock=sci
                if (comp == 3)
                {
                    lblResultcomp.Text = "Scissor";
                    picComp.Image = Properties.Resources.sic;
                    lblWin.Text = player + " Won!! ";
                    playSco++;
                    lblPlaysco.Text = playSco.ToString();
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.Winnin);
                    audio.Play();
                }
                //rock=paper
                else if (comp == 2)
                {
                    lblResultcomp.Text = "Paper";
                    picComp.Image = Properties.Resources.paper;
                    lblWin.Text = player + " Lose!! ";
                    compSco++;
                    lblCompsco.Text = compSco.ToString();
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.LOSING);
                    audio.Play();
                }
                //rock=rock
                else if (comp == 1)
                {
                    lblResultcomp.Text = "Rock";
                    picComp.Image = Properties.Resources.rock;
                    lblWin.Text = "TIE";
                    tie++;
                    lblTie.Text = tie.ToString();
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.TIE);
                    audio.Play();
                }
            }


            //if player chose paper
            else if (rdbPaper.Checked)
            {
                picUse.Image = Properties.Resources.paper2;


                //paper=sci
                if (comp == 3)
                {
                    lblResultcomp.Text = "Scissor";
                    picComp.Image = Properties.Resources.sic;
                    lblWin.Text = player + "Lose!! ";
                    compSco++;
                    lblCompsco.Text = compSco.ToString();
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.LOSING);
                    audio.Play();
                }
                //paper=paper
                else if (comp == 2)
                {
                    lblResultcomp.Text = "Paper";
                    picComp.Image = Properties.Resources.paper;
                    lblWin.Text = "TIE";
                    tie++;
                    lblTie.Text = tie.ToString();
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.TIE);
                    audio.Play();
                }
                //Paper=rock
                else if (comp == 1)
                {
                    lblResultcomp.Text = "Rock";
                    picComp.Image = Properties.Resources.rock;
                    lblWin.Text = player + " Won!! ";
                    playSco++;
                    lblPlaysco.Text = playSco.ToString();
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.Winnin);
                    audio.Play();
                }




            }


            //if player chose scissor
            else if (rdbSci.Checked)
            {
                picUse.Image = Properties.Resources.sic2;

                //sci=sci
                if (comp == 3)
                {
                    lblResultcomp.Text = "Scissor";
                    picComp.Image = Properties.Resources.sic;
                    lblWin.Text = "TIE";
                    tie++;
                    lblTie.Text = tie.ToString();
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.TIE);
                    audio.Play();
                }
                //sci=paper
                else if (comp == 2)
                {
                    lblResultcomp.Text = "Paper";
                    picComp.Image = Properties.Resources.paper;
                    lblWin.Text = player + " Won!!";
                    playSco++;
                    lblPlaysco.Text = playSco.ToString();
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.Winnin);
                    audio.Play();
                }
                //sci=rock
                else if (comp == 1)
                {
                    lblResultcomp.Text = "Rock";
                    picComp.Image = Properties.Resources.rock;
                    lblWin.Text = player + " Lose!! ";
                    compSco++;
                    lblCompsco.Text = compSco.ToString();
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.LOSING);
                    audio.Play();
                }


            }



            else
                MessageBox.Show("PLEASE CHOOSE ONE");

            
        }

        private void rdbSci_CheckedChanged(object sender, EventArgs e)
        {
            picUse.Image = null;
            SoundPlayer audio = new SoundPlayer();
            audio.Stop();
        }

        private void rdbPaper_CheckedChanged(object sender, EventArgs e)
        {
            picUse.Image = null;
            SoundPlayer audio = new SoundPlayer();
            audio.Stop();
        }

        private void rdbRock_CheckedChanged(object sender, EventArgs e)
        {
            picUse.Image = null;
            SoundPlayer audio = new SoundPlayer();
            audio.Stop();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //restart gane button
            Application.Restart();
        }
    }
}
