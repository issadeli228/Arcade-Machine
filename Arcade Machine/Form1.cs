using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Arcade_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartLabel_Click(object sender, EventArgs e)
        {
            //StartLabel.BackColor = Color.Black;
            CountdownLabel.ForeColor = Color.Gray;
            CountdownLabel3.ForeColor = Color.Gray;
            CountdownLabel2.Visible = false;
            CountdownLabel1.Visible = false;
            SoundPlayer AlertPlayer = new SoundPlayer(Properties.Resources._124899__greencouch__beeps_18_1);
            AlertPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            CountdownLabel3.Visible = false;
            CountdownLabel2.Visible = true;
            CountdownLabel2.ForeColor = Color.Gray;
            AlertPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            CountdownLabel2.Visible = false;
            CountdownLabel1.Visible = true;
            CountdownLabel1.ForeColor = Color.Gray;
            AlertPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            CountdownLabel.Visible = false;
            CountdownLabel1.Visible = false;

            GoLabel.ForeColor = Color.Black;
            GoLabel.BackColor = Color.Green;
            BackColor = Color.Green;
            SoundPlayer ArcadePlayer = new SoundPlayer(Properties.Resources._242138__harrypeeks__arcade_change);
            ArcadePlayer.Play();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CoountdownLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
