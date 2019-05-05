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
    public partial class Fuel_Calculator : Form
    {
        public Fuel_Calculator()
        {
            InitializeComponent();
        }

        int austria = 0;
        double austriaprice = 0;
        int belgium = 0;
        double belgiumprice = 0;
        int czech = 0;
        double czechprice = 0;
        int denmark = 0;
        double denmarkprice = 0;
        int england = 0;
        double englandprice = 0;
        int france = 0;
        double franceprice = 0;
        int germany = 0;
        double germanyprice = 0;
        int hungary = 0;
        double hungaryprice = 0;
        int italy = 0;
        double italyprice = 0;
        int luxembourg = 0;
        double luxembourgprice = 0;
        int netherlands = 0;
        double netherlandsprice = 0;
        int norway = 0;
        double norwayprice = 0;
        int poland = 0;
        double polandprice = 0;
        int slovakia = 0;
        double slovakiaprice = 0;
        int sweden = 0;
        double swedenprice = 0;
        int switzerland = 0;
        double switzerlandprice = 0;

        private void Fuel_Calculator_Load(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            austria++;
            austriaprice = austriaprice + 1.31;
            textBox1.Text = austria.ToString();
            textBox2.Text = austriaprice.ToString();

            if (austria == 1400)
            {
                button1.Enabled = false;
            }
            if (austriaprice >= 0)
            {
                button2.Enabled = true;
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox270_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            austria--;
            austriaprice = austriaprice - 1.31;
            textBox1.Text = austria.ToString();
            textBox2.Text = austriaprice.ToString();

            if (austria == 0)
            {
                button2.Enabled = false;
            }
            if (austriaprice <= 1400)
            {
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            belgium++;
            belgiumprice = belgiumprice + 1.56;
            textBox3.Text = belgium.ToString();
            textBox4.Text = belgiumprice.ToString();

            if (belgium == 1400)
            {
                button3.Enabled = false;
            }
            if (belgiumprice >= 0)
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            belgium--;
            belgiumprice = belgiumprice - 1.56;
            textBox3.Text = belgium.ToString();
            textBox4.Text = belgiumprice.ToString();

            if (belgium == 0)
            {
                button4.Enabled = false;
            }
            if (belgiumprice <= 1400)
            {
                button3.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            czech++;
            czechprice = czechprice + 1.28;
            textBox5.Text = czech.ToString();
            textBox6.Text = czechprice.ToString();

            if (czech == 1400)
            {
                button5.Enabled = false;
            }
            if (czechprice >= 0)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            czech--;
            czechprice = czechprice - 1.28;
            textBox5.Text = czech.ToString();
            textBox6.Text = czechprice.ToString();

            if (czech == 0)
            {
                button6.Enabled = false;
            }
            if (czech <= 1400)
            {
                button5.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            denmark++;
            denmarkprice = denmarkprice + 1.54;
            textBox7.Text = denmark.ToString();
            textBox8.Text = denmarkprice.ToString();

            if (denmark == 1400)
            {
                button7.Enabled = false;
            }
            if (denmark >= 0)
            {
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            denmark--;
            denmarkprice = denmarkprice - 1.54;
            textBox7.Text = denmark.ToString();
            textBox8.Text = denmarkprice.ToString();

            if (denmark == 0)
            {
                button8.Enabled = false;
            }
            if (denmark <= 1400)
            {
                button7.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            england++;
            englandprice = englandprice + 1.55;
            textBox9.Text = england.ToString();
            textBox10.Text = englandprice.ToString();

            if (england == 1400)
            {
                button9.Enabled = false;
            }
            if (england >= 0)
            {
                button10.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            england--;
            englandprice = englandprice - 1.55;
            textBox9.Text = england.ToString();
            textBox10.Text = englandprice.ToString();

            if (england == 0)
            {
                button10.Enabled = false;
            }
            if (england <= 1400)
            {
                button9.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            france++;
            franceprice = franceprice + 1.54;
            textBox11.Text = france.ToString();
            textBox12.Text = franceprice.ToString();

            if (france == 1400)
            {
                button11.Enabled = false;
            }
            if (france >= 0)
            {
                button12.Enabled = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            france--;
            franceprice = franceprice - 1.54;
            textBox11.Text = france.ToString();
            textBox12.Text = franceprice.ToString();

            if (france == 0)
            {
                button12.Enabled = false;
            }
            if (france <= 1400)
            {
                button11.Enabled = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            germany++;
            germanyprice = germanyprice + 1.31;
            textBox13.Text = germany.ToString();
            textBox14.Text = germanyprice.ToString();

            if (germany == 1400)
            {
                button13.Enabled = false;
            }
            if (germany >= 0)
            {
                button14.Enabled = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            germany--;
            germanyprice = germanyprice - 1.31;
            textBox13.Text = germany.ToString();
            textBox14.Text = germanyprice.ToString();

            if (germany == 0)
            {
                button14.Enabled = false;
            }
            if (germany <= 1400)
            {
                button13.Enabled = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hungary++;
            hungaryprice = hungaryprice + 1.31;
            textBox15.Text = hungary.ToString();
            textBox16.Text = hungaryprice.ToString();

            if (hungary == 1400)
            {
                button15.Enabled = false;
            }
            if (hungary >= 0)
            {
                button16.Enabled = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hungary--;
            hungaryprice = hungaryprice - 1.31;
            textBox15.Text = hungary.ToString();
            textBox16.Text = hungaryprice.ToString();

            if (hungary == 0)
            {
                button16.Enabled = false;
            }
            if (hungary <= 1400)
            {
                button15.Enabled = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            italy++;
            italyprice = italyprice + 1.53;
            textBox17.Text = italy.ToString();
            textBox18.Text = italyprice.ToString();

            if (italy == 1400)
            {
                button17.Enabled = false;
            }
            if (italy >= 0)
            {
                button18.Enabled = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            italy--;
            italyprice = italyprice - 1.53;
            textBox17.Text = italy.ToString();
            textBox18.Text = italyprice.ToString();

            if (italy == 0)
            {
                button18.Enabled = false;
            }
            if (italy <= 1400)
            {
                button17.Enabled = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            luxembourg++;
            luxembourgprice = luxembourgprice + 1.18;
            textBox19.Text = luxembourg.ToString();
            textBox20.Text = luxembourgprice.ToString();

            if (luxembourg == 1400)
            {
                button19.Enabled = false;
            }
            if (luxembourg >= 0)
            {
                button20.Enabled = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            luxembourg--;
            luxembourgprice = luxembourgprice - 1.18;
            textBox19.Text = luxembourg.ToString();
            textBox20.Text = luxembourgprice.ToString();

            if (luxembourg == 0)
            {
                button20.Enabled = false;
            }
            if (luxembourg <= 1400)
            {
                button19.Enabled = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            netherlands++;
            netherlandsprice = netherlandsprice + 1.40;
            textBox21.Text = netherlands.ToString();
            textBox22.Text = netherlandsprice.ToString();

            if (netherlands == 1400)
            {
                button21.Enabled = false;
            }
            if (netherlands >= 0)
            {
                button22.Enabled = true;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            netherlands--;
            netherlandsprice = netherlandsprice - 1.40;
            textBox21.Text = netherlands.ToString();
            textBox22.Text = netherlandsprice.ToString();

            if (netherlands == 0)
            {
                button22.Enabled = false;
            }
            if (netherlands <= 1400)
            {
                button21.Enabled = true;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            norway++;
            norwayprice = norwayprice + 1.71;
            textBox23.Text = norway.ToString();
            textBox24.Text = norwayprice.ToString();

            if (norway == 1400)
            {
                button23.Enabled = false;
            }
            if (netherlands >= 0)
            {
                button24.Enabled = true;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            norway--;
            norwayprice = norwayprice - 1.71;
            textBox23.Text = norway.ToString();
            textBox24.Text = norwayprice.ToString();

            if (norway == 0)
            {
                button24.Enabled = false;
            }
            if (norway <= 1400)
            {
                button23.Enabled = true;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            poland++;
            polandprice = polandprice + 1.18;
            textBox25.Text = poland.ToString();
            textBox26.Text = polandprice.ToString();

            if (poland == 1400)
            {
                button25.Enabled = false;
            }
            if (poland >= 0)
            {
                button26.Enabled = true;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            poland--;
            polandprice = polandprice - 1.18;
            textBox25.Text = poland.ToString();
            textBox26.Text = polandprice.ToString();

            if (poland == 0)
            {
                button26.Enabled = false;
            }
            if (poland <= 1400)
            {
                button25.Enabled = true;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            slovakia++;
            slovakiaprice = slovakiaprice + 1.29;
            textBox27.Text = slovakia.ToString();
            textBox28.Text = slovakiaprice.ToString();

            if (slovakia == 1400)
            {
                button27.Enabled = false;
            }
            if (slovakia >= 0)
            {
                button28.Enabled = true;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            slovakia--;
            slovakiaprice = slovakiaprice - 1.29;
            textBox27.Text = slovakia.ToString();
            textBox28.Text = slovakiaprice.ToString();

            if (slovakia == 0)
            {
                button28.Enabled = false;
            }
            if (slovakia <= 1400)
            {
                button27.Enabled = true;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            sweden++;
            swedenprice = swedenprice + 1.61;
            textBox29.Text = sweden.ToString();
            textBox30.Text = swedenprice.ToString();

            if (sweden == 1400)
            {
                button29.Enabled = false;
            }
            if (sweden >= 0)
            {
                button30.Enabled = true;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            sweden--;
            swedenprice = swedenprice - 1.61;
            textBox29.Text = sweden.ToString();
            textBox30.Text = swedenprice.ToString();

            if (sweden == 0)
            {
                button30.Enabled = false;
            }
            if (sweden <= 1400)
            {
                button29.Enabled = true;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            switzerland++;
            switzerlandprice = switzerlandprice + 1.53;
            textBox31.Text = switzerland.ToString();
            textBox32.Text = switzerlandprice.ToString();

            if (switzerland == 1400)
            {
                button31.Enabled = false;
            }
            if (switzerland >= 0)
            {
                button32.Enabled = true;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            switzerland--;
            switzerlandprice = switzerlandprice - 1.53;
            textBox31.Text = switzerland.ToString();
            textBox32.Text = switzerlandprice.ToString();

            if (switzerland == 0)
            {
                button32.Enabled = false;
            }
            if (switzerland <= 1400)
            {
                button31.Enabled = true;
            }
        }
    }
}
