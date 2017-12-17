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
    public partial class Form3 : Form
    {
        bool a, b, c ,go;
        int raed, orng, grn,cr , i;
        Point p2 = new Point(500, 468);

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cart_Tick(object sender, EventArgs e)
        {
            cr = cr - 2;
            if (cr < 0)
            {
                cr = this.Height;
            }
            Point p1 = new Point(500, cr);
            car.Location = p1;
            if (car.Location == p2)
            {
                if (go == false)
                {
                    cart.Enabled = false;
                }
            }
        }

        private void Fan_Tick_1(object sender, EventArgs e)
        {
            traf(raed, orng, grn, i);

            i = i + 1;
            if (i == raed + orng + grn + 1)
            {
                i = 0;
            }
            if (Red.Visible == true)
            {
                go = false;
            }
            if (Green.Visible == true)
            {
                go = true;
                if (car.Location == p2)
                {
                    cart.Enabled = true; 
                }
            }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            a = int.TryParse(Redtxt.Text, out raed);
            b = int.TryParse(Orngtxt.Text, out orng);
            c = int.TryParse(Grntxt.Text, out grn);
            if ((a == true) && (b == true) && (c == true))
            {
                raed = raed - 1;
                Fan.Enabled = true;
                cart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Only numbers!!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            traffic();
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
        }
    }


