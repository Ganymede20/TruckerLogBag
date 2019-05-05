using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trucker_Log_Bag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Codded by Ganymede© 2018-2019
        //https://truckerlogbag.com

        private void button3_Click(object sender, EventArgs e)
        {
            ETS2Map ets2map = new ETS2Map();
            ets2map.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TMP_Server_Status tmpserverstatus = new TMP_Server_Status();
            tmpserverstatus.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fuel_Calculator fuelcalculator = new Fuel_Calculator();
            fuelcalculator.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://truckerlogbag.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://forum.truckerlogbag.com/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://support.truckerlogbag.com/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fuel_Calculator_for_ATS fuelcalulatorforats = new Fuel_Calculator_for_ATS();
            fuelcalulatorforats.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WOT wot = new WOT();
            wot.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SCS scs = new SCS();
            scs.Show();
        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.truckerlogbag.com/showthread.php?tid=4");
        }
    }
}
