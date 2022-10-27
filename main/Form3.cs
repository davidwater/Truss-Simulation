using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末專題
{
    public partial class num1 : Form
    {
        public num1()
        {
            InitializeComponent();
        }

        private void num1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\picture\1.jpg");
            label1.Text = "Determine the force in each member of the truss and state if the members are in tension or compression. Set  P1 = 20 kN, P2 = 10 kN.";
           
        }

        double a, b, c, d;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                b = double.Parse(textBox2.Text);
                if (b != 0)
                {
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                }
                else
                {
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                }
            }
            catch
            {
                textBox2.Clear();
            }

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                c = double.Parse(textBox3.Text);
                if (c != 0)
                {
                    radioButton5.Enabled = true;
                    radioButton6.Enabled = true;
                }
                else
                {
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    radioButton5.Enabled = false;
                    radioButton6.Enabled = false;
                }
            }
            catch
            {
                textBox3.Clear();
            }
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            
            try
            {
                d = double.Parse(textBox4.Text);
                if (d != 0)
                {
                    radioButton7.Enabled = true;
                    radioButton8.Enabled = true;
                }
                else
                {
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    radioButton7.Enabled = false;
                    radioButton8.Enabled = false;
                }
                btnenable();
            }
            catch
            {
                textBox4.Clear();
            }
           

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = (Form2)this.Owner;
            f.StrValue = k.ToString();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                a = double.Parse(textBox1.Text);
                if (a != 0)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                }

            }
            catch
            {
                textBox1.Clear();
            }


        }

        private void btnenable()
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                button1.Enabled = true;
            }
        }

        int x, y, z, w, k;
        private void button1_Click(object sender, EventArgs e)
        {
           

 
            if( a==0 )
            {
                x = 2;
                label6.Text = "答對2題";
            }
            else
            {
                x = 0;                
                label6.Text = "答對0題";
                textBox1.BackColor = Color.Red;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            
            if( b==20 && radioButton4.Checked != true)
            {
                y = 1;
                label7.Text = "答對1題";
                radioButton3.BackColor = Color.Red;
            }
            if (b != 20 && radioButton4.Checked == true)
            {
                y = 1;
                label7.Text = "答對1題";
                textBox2.BackColor = Color.Red;
            }
            if ( b == 20 && radioButton4.Checked == true)
            {
                y = 2;
                label7.Text = "答對2題";
            }
            else
            {
                y = 0;
                label7.Text = "答對0題";
                textBox2.BackColor = Color.Red;
                radioButton3.BackColor = Color.Red;
            }

            if( c==33.3 && radioButton5.Checked != true)
            {
                z = 1;
                label8.Text = "答對1題";
                radioButton6.BackColor = Color.Red;
            }
            if (c != 33.3 && radioButton5.Checked == true)
            {
                z = 1;
                label8.Text = "答對1題";
                textBox3.BackColor = Color.Red;
            }
            if ( c == 33.3 && radioButton5.Checked == true)
            {
                z = 2;
                label8.Text = "答對2題";
            }
            else
            {
                z = 0;
                label8.Text = "答對0題";
                textBox3.BackColor = Color.Red;
                radioButton6.BackColor = Color.Red;
            }

            if( d==36.7 && radioButton8.Checked != true)
            {
                w = 1;
                label9.Text = "答對1題";
                radioButton7.BackColor = Color.Red;
            }
            if (d == 36.7 && radioButton8.Checked != true)
            {
                w = 1;
                label9.Text = "答對1題";
                textBox4.BackColor = Color.Red;
            }
            if (d == 36.7 && radioButton8.Checked == true)
            {
                w = 2;
                label9.Text = "答對2題";
            }
            else
            {
                w = 0;
                label9.Text = "答對0題";
                textBox4.BackColor = Color.Red;
                radioButton7.BackColor = Color.Red;
            }
            button1.Enabled = false;
            k = x + y + z + w;
        }
    }
}
