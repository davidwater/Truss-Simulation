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
    public partial class num9 : Form
    {
        public num9()
        {
            InitializeComponent();
        }

        private void num9_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\picture\9.jpg");
            label1.Text = "Determine the force in each member of the trussand state if the members are in tension or compression. Assume each joint as a pin. Set P = 4 kN.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = (Form2)this.Owner;
            f.StrValue = w.ToString();
            this.Close();
        }

        double a, b, c;

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
            btnenable();
        }
        private void btnenable()
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" )
            {
                button1.Enabled = true;
            }
        }
        int x, y, z, w;
        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 8.94 && radioButton2.Checked == true)
            {
                x = 2;
                label11.Text = "答對2題";

            }
            if (a != 8.94 && radioButton2.Checked == true)
            {
                x = 1;
                label11.Text = "答對1題";
                textBox1.BackColor = Color.Red;
            }
            if (a == 8.94 && radioButton2.Checked != true)
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

            if (b == 8 && radioButton3.Checked == true)
            {
                y = 2;
                label12.Text = "答對2題";

            }
            if (a != 8 && radioButton3.Checked == true)
            {
                y = 1;
                label12.Text = "答對1題";
                textBox2.BackColor = Color.Red;
            }
            if (a == 8 && radioButton3.Checked != true)
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

            if (c == 8 && radioButton5.Checked == true)
            {
                z = 2;
                label13.Text = "答對2題";

            }
            if (c != 8 && radioButton5.Checked == true)
            {
                z = 1;
                label13.Text = "答對1題";
                textBox3.BackColor = Color.Red;
            }
            if (c == 8 && radioButton5.Checked != true)
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
            w = x + y + z;
            button1.Enabled = false;
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
