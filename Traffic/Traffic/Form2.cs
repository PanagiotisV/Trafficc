using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic
{
    public partial class Form2 : Form
    {
        bool a, b, c;
        int raed, orng, grn, i;
        public Form2()
        {
            InitializeComponent();
        }
        public void traf(int rad, int ar, int gre, int p)
        {
            if (p == rad)
            {
                traffic();
            }
            if (p == rad + gre)
            {
                traffic();
            }
            if (p == rad + ar + gre)
            {
                traffic();

            }
        }

        private void Fan_Tick(object sender, EventArgs e)
        {
            traf(raed, orng, grn, i);

            i = i + 1;
            if (i == raed + orng + grn + 1)
            {
                i = 0;
            }
        }

        public void traffic()
        {
            if (Red.Visible == true)
            {
                Red.Visible = false;
                Orange.Visible = false;
                Green.Visible = true;
            }
            else if (Orange.Visible == true)
            {
                Red.Visible = true;
                Orange.Visible = false;
                Green.Visible = false;
            }
            else if (Green.Visible == true)
            {
                Green.Visible = false;
                Orange.Visible = true;
                Red.Visible = false;
            }
        }

        private void Green_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            traffic();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = int.TryParse(Redtxt.Text, out raed);
            b = int.TryParse(Orngtxt.Text, out orng);
            c = int.TryParse(Grntxt.Text, out grn);
            if ((a == true) && (b == true) && (c == true) )
            {
                raed = raed - 1;
                Fan.Enabled = true;
            }
            else
            {
                MessageBox.Show("Only numbers!!");
            }
        }
    }
}
