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
    public partial class Fuel_Calculator_for_ATS : Form
    {
        public Fuel_Calculator_for_ATS()
        {
            InitializeComponent();
        }

        int arizona = 0;
        double arizonaprice = 0;
        int california = 0;
        double californiaprice = 0;
        int nevada = 0;
        double nevadaprice = 0;
        int newmexico = 0;
        double newmexicoprice = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            arizona++;
            arizonaprice = arizonaprice + 0.82;
            textBox1.Text = arizona.ToString();
            textBox2.Text = arizonaprice.ToString();
            
            if (arizona == 1136)
            {
                button1.Enabled = false;
            }
            if (arizonaprice >= 0)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arizona--;
            arizonaprice = arizonaprice - 0.82;
            textBox1.Text = arizona.ToString();
            textBox2.Text = arizonaprice.ToString();

            if (arizona == 0)
            {
                button2.Enabled = false;
            }
            if (arizonaprice <= 1136)
            {
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            california++;
            californiaprice = californiaprice + 1.04;
            textBox3.Text = california.ToString();
            textBox4.Text = californiaprice.ToString();

            if (california == 1136)
            {
                button3.Enabled = false;
            }
            if (californiaprice >= 0)
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            california--;
            californiaprice = californiaprice - 1.04;
            textBox3.Text = california.ToString();
            textBox4.Text = californiaprice.ToString();

            if (california == 0)
            {
                button4.Enabled = false;
            }
            if (californiaprice <= 1136)
            {
                button3.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nevada++;
            nevadaprice = nevadaprice + 0.89;
            textBox5.Text = nevada.ToString();
            textBox6.Text = nevadaprice.ToString();

            if (nevada == 1136)
            {
                button5.Enabled = false;
            }
            if (nevada >= 0)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nevada--;
            nevadaprice = nevadaprice - 0.89;
            textBox5.Text = nevada.ToString();
            textBox6.Text = nevadaprice.ToString();

            if (nevada == 0)
            {
                button6.Enabled = false;
            }
            if (nevada <= 1136)
            {
                button5.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            newmexico++;
            newmexicoprice = newmexicoprice + 0.82;
            textBox7.Text = newmexico.ToString();
            textBox8.Text = newmexicoprice.ToString();

            if (newmexico == 1136)
            {
                button7.Enabled = false;
            }
            if (newmexico >= 0)
            {
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            newmexico--;
            newmexicoprice = newmexicoprice - 0.82;
            textBox7.Text = newmexico.ToString();
            textBox8.Text = newmexicoprice.ToString();

            if (newmexico == 0)
            {
                button8.Enabled = false;
            }
            if (newmexico <= 1136)
            {
                button7.Enabled = true;
            }
        }
    }
}
