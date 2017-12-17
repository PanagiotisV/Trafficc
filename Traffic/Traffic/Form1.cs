using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic
{
    public partial class Red : Form
    {
        
        int  raed, orng, grn, raed2, orng2, grn2, i, l, cr, cr2 = 0;
        Point q1 = new Point(500, 611);
        
        
        bool ye, go, go2 = true;
        bool a, b, c, d, f, g = false;

        //That's the manual
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red light 2 must equal with Green light 1 + Orange light 1" + Environment.NewLine + "Orange light 1 must be equal to Orange light 2" + Environment.NewLine + "Green light 2 must be equal to Red light 1 - Orange light 1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.Show();
        }

        //Moving the second car
        private void cart2_Tick(object sender, EventArgs e)
        {
            cr2 = cr2 + 1 ;
            if (cr2 > this.Width)
            {
                cr2 = 0;
            }
            if (cr2 == 280)
            {
                if (go2 == false)
                {
                    cart2.Enabled = false;
                }
            }
            Point p2 = new Point(cr2, 274);
            car2.Location = p2;

        }
        //Switching the lights on the second traffic 
        private void Fan2_Tick(object sender, EventArgs e)
        {

            traf2(raed2, orng2, grn2, l);

            l = l + 1;
            if (l == raed2 + orng2 + grn2 + 1)
            {
                l = 0;
            }

        }
        //unrelated
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //That checks when the lights need to switch on the first traffic
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
        //That checks when the lights need to switch on the second traffic
        public void traf2(int rad2,int ar2, int gre2, int p2)
        {
            if (p2 == gre2)
            {
                traffic2();
            }
            if (p2 == gre2 + ar2)
            {
                traffic2();
            }
            if (p2 == rad2 + ar2 + gre2)
            {
                traffic2();

            }
        }
        //General code to change the lights on first traffic
        public void traffic()
        {
            if (Red1.Visible == true)
            {
                Red1.Visible = false;
                Orange.Visible = false;
                Green.Visible = true;
                go = true;
                cart.Enabled = true;

            }
            else if (Orange.Visible == true)
            {
                Red1.Visible = true;
                Orange.Visible = false;
                Green.Visible = false;
                go = false;
                
               
            }
            else if (Green.Visible == true)
            {
                Green.Visible = false;
                Orange.Visible = true;
                Red1.Visible = false;
                go = false;
                
            }
        }
        //General code to change the lights on second traffic
        public void traffic2()
        {
            if (Red2.Visible == true)
            {
                Red2.Visible = false;
                Orange2.Visible = false ;
                Green2.Visible = true;
                go2 = true;
                cart2.Enabled = true;
            }
            else if (Orange2.Visible == true)
            {
                Red2.Visible = true;
                Orange2.Visible = false;
                Green2.Visible = false;
                go2 = false;
                

            }
            else if (Green2.Visible == true)
            {
                Green2.Visible = false;
                Orange2.Visible = true;
                Red2.Visible = false;
                go2 = false;
            }
        }
        public Red()
        {
            InitializeComponent();
            int cr = this.Height;
            int cr2 = 0;


        }
        //That's the change button for the second traffic
        private void button4_Click(object sender, EventArgs e)
        {
            traffic2();
            Fan2.Enabled = false;
        }
        //That disables the traffics
        private void button3_Click(object sender, EventArgs e)
        {
            ye = false;
            Fan.Enabled = false;
            Fan2.Enabled = false;
        }
        //Code for moving the first car
        private void car_Tick(object sender, EventArgs e)
        {
            
            cr = cr - 1;
            if (cr < 0)
            {
                cr = this.Height;
            }
            if (cr == 611)
            {
                if (go == false){
                    cart.Enabled = false;
                }
            }
            if ((cr < 354) && (cr>268))
            {


                if ((cr2 > 345) && (cr2 < 564))
                {
                    cart.Enabled = false;
                }
            }
            Point p1 = new Point(500,cr);
            car.Location = p1;
            
        }
        //unrelated
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //unrelated
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //That's the change button for the first traffic
        private void button1_Click(object sender, EventArgs e)
        {
            traffic();
            Fan.Enabled = false;
           
        }
        //The auto button
        private void button2_Click(object sender, EventArgs e)
        {
            
            ye = true;
           
            a = int.TryParse(textBox1.Text, out raed);
            b = int.TryParse(textBox2.Text, out orng);
            c = int.TryParse(textBox3.Text, out grn);
            d = int.TryParse(textBox6.Text, out raed2);
            f = int.TryParse(textBox5.Text, out orng2);
            g = int.TryParse(textBox4.Text, out grn2);
            if ((a == true && b == true && c == true) && (d == true && f == true && g == true))
            {
                if ((raed2 != grn + orng) || (orng2 != orng) || (grn2 != raed - orng))
                {
                    MessageBox.Show("Wrong numbers. The cars may crash. Refer to manual.");
                    raed = raed - 1;
                    raed2 = raed2 - 1;
                    Fan.Enabled = true;
                    Fan2.Enabled = true;
                    cart.Enabled = true;
                    cart2.Enabled = true;
                }
                else
                {
                    raed = raed - 1;
                    raed2 = raed2 - 1;
                    Fan.Enabled = true;
                    Fan2.Enabled = true;
                    cart.Enabled = true;
                    cart2.Enabled = true;
                }
            }
            
            
    
        }
        //Switching the lights on the first traffic 
        private void Fan_Tick(object sender, EventArgs e)
        {


         traf(raed, orng, grn, i);

         i = i + 1;
        if ( i == raed + orng + grn + 1 )
            {
                i = 0;
            }
            
            
        }
    }
}
