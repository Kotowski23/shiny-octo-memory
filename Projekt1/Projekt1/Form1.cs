using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace Projekt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0; // Define i at class level

        public object Class1 { get; private set; }
        

        public void button1_Click(object sender, EventArgs e)
        {
          

            Random x = new Random();

            
            if (textBox2.Text == "active")
            {
                i = i + 2;
            }
            else
            {
                 i++;
            }

            string wallnut = textBox4.Text;
            if (wallnut == "active")
            {
                Point pt2 = new Point(
                    int.Parse(x.Next(250, 350).ToString()),
                    int.Parse(x.Next(50, 150).ToString())
                   );
                button1.Location = pt2;
            }
            else
            {
                Point pt = new Point(
                     int.Parse(x.Next(120, 450).ToString()),
                     int.Parse(x.Next(50, 150).ToString())
                    );

                button1.Location = pt;
            }
            textBox1.Text = i.ToString();
            


        }

        public void button2_Click(object sender, EventArgs e)
        {
            string a = "not active";
            string afive = textBox2.Text;
             if (i >= 50 && afive == "50$")
            {
                i = i - 50;
                textBox1.Text = i.ToString();

                a = "active";
                textBox2.Text = a;
                pictureBox6.Visible = true;

                int x1 = 160;
                int y1 = 317;
                Point pt = new Point(
                     int.Parse(x1.ToString()),
                     int.Parse(y1.ToString())
                    );

                pictureBox6.Location = pt;
            }

           


        }

        private void button8_Click(object sender, EventArgs e)
        {
           
           
            textBox2.Text = "50$";
            textBox3.Text = "60$";
            textBox4.Text = "80$";
            button8.Visible = false;
            button1.Visible = true;
            button9.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string b;
            string afive = textBox4.Text;


            if (i >= 80 && afive == "80$")
            {
               
                i = i - 80;
                textBox1.Text = i.ToString();

                b = "active";
                textBox4.Text = b;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                int x1 = 432;
                int y1 = 32;
                Point pt = new Point(
                     int.Parse(x1.ToString()),
                     int.Parse(y1.ToString())
                    );

                pictureBox9.Location = pt;

                int x2 = 204;
                int y2 = 32;
                Point pt2 = new Point(
                     int.Parse(x2.ToString()),
                     int.Parse(y2.ToString())
                    );

                pictureBox8.Location = pt2;

                int x3 = 260;
                int y3 = 67;
                Point pt3 = new Point(
                     int.Parse(x3.ToString()),
                     int.Parse(y3.ToString())
                    );

                button9.Location = pt3;

                int x4 = 238;
                int y4 = 313;
                Point pt4 = new Point(
                     int.Parse(x4.ToString()),
                     int.Parse(y4.ToString())
                    );

                pictureBox7.Location = pt4;
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            

            Random x = new Random();


            if (textBox3.Text == "active")
            {
                i = i + 5;
            }
            else
            {
                if (textBox2.Text == "active")
                {
                    i = i + 2;
                }
                else
                {
                    i++;
                }
            }
            string wallnut = textBox4.Text;
            if (wallnut == "active")
            {
                Point pt2 = new Point(
                    int.Parse(x.Next(272, 300).ToString()),
                    int.Parse(x.Next(50, 120).ToString())
                   );
                button9.Location = pt2;
            }
            else
            {
                Point pt = new Point(
                     int.Parse(x.Next(120, 450).ToString()),
                     int.Parse(x.Next(50, 150).ToString())
                    );

                button9.Location = pt;
            }
               
            textBox1.Text = i.ToString();
          
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string b;
            string afive = textBox3.Text;

          
            if (i >= 60 && afive == "60$")
            {
                button1.Visible = false;
                button9.Visible = true;
                i = i - 60;
                textBox1.Text = i.ToString();

                b = "active";
                textBox3.Text = b;
                int x1 = 260;
                int y1 = 67;
                Point pt = new Point(
                     int.Parse(x1.ToString()),
                     int.Parse(y1.ToString())
                    );

               button9.Location = pt;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

          
        }

       
    }
}
