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
    public partial class num3 : Form
    {
        public num3()
        {
            InitializeComponent();
        }

        private void num3_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\picture\3.jpg");
            label1.Text = "The truss, used to support a balcony, is subjected tothe loading shown. Approximate each joint as a pin anddetermine the force in each member. State whether the members are in tension or compression. Set P1 = 800 lb and P2 = 0.";
            
        }

        double a, b, c, d;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c = double.Parse(textBox6.Text);
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
                textBox6.Clear();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                d = double.Parse(textBox7.Text);
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
                
            }
            catch
            {
                textBox7.Clear();
            }
            btnenable();
        }
        private void btnenable()
        {
            if (textBox1.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox7.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = double.Parse(textBox5.Text);
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
                textBox5.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = (Form2)this.Owner;
            f.StrValue = k.ToString();
            this.Close();
        }

        int x, y, z, w, k;

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

        private void button1_Click(object sender, EventArgs e)
        {


            if (a == 0)
            {
                x = 2;
                label9.Text = "答對2題";
            }
            else
            {
                x = 0;
                label9.Text = "答對0題";
                textBox1.BackColor = Color.Red;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }

            if (b == 800 && radioButton4.Checked != true)
            {
                y = 1;
                label10.Text = "答對1題";
                radioButton3.BackColor = Color.Red;
            }
            if (b != 800 && radioButton4.Checked == true)
            {
                y = 1;
                label10.Text = "答對1題";
                textBox5.BackColor = Color.Red;
            }
            if (b == 800 && radioButton4.Checked == true)
            {
                y = 2;
                label10.Text = "答對2題";
            }
            else
            {
                y = 0;
                label10.Text = "答對0題";
                textBox5.BackColor = Color.Red;
                radioButton3.BackColor = Color.Red;
            }

            if (c == 800 && radioButton5.Checked != true)
            {
                z = 1;
                label11.Text = "答對1題";
                radioButton6.BackColor = Color.Red;
            }
            if (c != 800 && radioButton5.Checked == true)
            {
                z = 1;
                label11.Text = "答對1題";
                textBox6.BackColor = Color.Red;
            }
            if (c == 800 && radioButton5.Checked == true)
            {
                z = 2;
                label11.Text = "答對2題";
            }
            else
            {
                z = 0;
                label11.Text = "答對0題";
                textBox6.BackColor = Color.Red;
                radioButton6.BackColor = Color.Red;
            }

            if (d == 1131 && radioButton8.Checked != true)
            {
                w = 1;
                label12.Text = "答對1題";
                radioButton7.BackColor = Color.Red;
            }
            if (d == 1131 && radioButton8.Checked != true)
            {
                w = 1;
                label12.Text = "答對1題";
                textBox7.BackColor = Color.Red;
            }
            if (d == 1131 && radioButton8.Checked == true)
            {
                w = 2;
                label12.Text = "答對2題";
            }
            else
            {
                w = 0;
                label12.Text = "答對0題";
                textBox7.BackColor = Color.Red;
                radioButton7.BackColor = Color.Red;
            }
            button1.Enabled = false;
            k = x + y + z + w;
        }
    }
}
