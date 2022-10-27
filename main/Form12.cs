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
    public partial class num10 : Form
    {
        public num10()
        {
            InitializeComponent();
        }

        private void num10_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\picture\10.jpg");
            label1.Text = "Determine the force in each member of the truss andstate if the members are in tension or compression. Set P1 = 2 kN and P2 =1.5 kN.";
        }
        double a, b, c, d;

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

            }
            catch
            {
                textBox4.Clear();
            }
            btnenable();
        }
        private void btnenable()
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" )
            {
                button1.Enabled = true;
            }
        }

        int x, y, z, w;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = (Form2)this.Owner;
            f.StrValue = w.ToString();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 3 && radioButton2.Checked == true)
            {
                x = 2;
                label11.Text = "答對2題";

            }
            if (a != 3 && radioButton2.Checked == true)
            {
                x = 1;
                label11.Text = "答對1題";
                textBox1.BackColor = Color.Red;
            }
            if (a == 3 && radioButton2.Checked != true)
            {
                x = 1;
                label11.Text = "答對1題";
                radioButton1.BackColor = Color.Red;
            }
            else
            {
                x = 0;
                label11.Text = "答對[0]題";
                radioButton1.BackColor = Color.Red;
                textBox1.BackColor = Color.Red;
            }

            if (b == 2.6 && radioButton3.Checked == true)
            {
                y = 2;
                label12.Text = "答對2題";

            }
            if (b != 2.6 && radioButton3.Checked == true)
            {
                y = 1;
                label12.Text = "答對1題";
                textBox2.BackColor = Color.Red;
            }
            if (b == 2.6 && radioButton3.Checked != true)
            {
                y = 1;
                label12.Text = "答對1題";
                radioButton4.BackColor = Color.Red;
            }
            else
            {
                y = 0;
                label12.Text = "答對0題";
                radioButton4.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
            }

            if (c == 2.6 && radioButton5.Checked == true)
            {
                z = 2;
                label13.Text = "答對2題";

            }
            if (c != 2.6 && radioButton5.Checked == true)
            {
                z = 1;
                label13.Text = "答對1題";
                textBox3.BackColor = Color.Red;
            }
            if (c == 2.6 && radioButton5.Checked != true)
            {
                z = 1;
                label13.Text = "答對1題";
                radioButton6.BackColor = Color.Red;
            }
            else
            {
                z = 0;
                label13.Text = "答對0題";
                radioButton6.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
            }

            if (d == 0)
            {
                w = 2;
                label14.Text = "答對2題";
            }
            else
            {
                w = 0;
                label14.Text = "答對0題";
                textBox4.BackColor = Color.Red;
                radioButton7.Enabled = false;
                radioButton8.Enabled = false;
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
    }
}
