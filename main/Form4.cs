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
    public partial class num2 : Form
    {
       
        public num2()
        {
            InitializeComponent();
        }

        private void num2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\picture\2.jpg");
            label1.Text = "Determine the force  in  each member of  the  truss. State if the members are in tension or compression.";
            label11.Text = "";
            label12.Text = ""; label13.Text = ""; label14.Text = ""; label15.Text = ""; label16.Text = ""; label17.Text = ""; label18.Text = ""; label19.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        double a, b, c, d, f, g, h, i, j;

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                j = double.Parse(textBox9.Text);
                if (j != 0)
                {
                    radioButton17.Enabled = true;
                    radioButton18.Enabled = true;
                }
                else
                {
                    radioButton17.Checked = false;
                    radioButton18.Checked = false;
                    radioButton17.Enabled = false;
                    radioButton18.Enabled = false;
                }

            }
            catch
            {
                textBox9.Clear();
            }
            btnenable();
        }

        private void btnenable()
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox7.Text != "" || textBox8.Text != "" || textBox9.Text != "")
            {
                button1.Enabled = true;
            }
        }
        int x, y, z, w, k, l, o, p, q, r;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(a==150 && radioButton2.Checked == true)
            {
                x = 2;
                label11.Text = "答對2題";

            }
            if(a!=150 && radioButton2.Checked ==true)
            {
                x = 1;
                label11.Text = "答對1題";
                textBox1.BackColor = Color.Red;
            }
            if (a == 150 && radioButton2.Checked != true)
            {
                x = 1;
                label11.Text = "答對1題";
                radioButton1.BackColor = Color.Red;
            }
            else
            {
                x = 0;
                label11.Text =  "答對0題" ;
                radioButton1.BackColor = Color.Red;
                textBox1.BackColor = Color.Red;
            }

            if (b == 140 && radioButton3.Checked == true)
            {
                y = 2;
                label12.Text = "答對2題";

            }
            if (a != 140 && radioButton3.Checked == true)
            {
                y = 1;
                label12.Text = "答對1題";
                textBox2.BackColor = Color.Red;
            }
            if (a == 140 && radioButton3.Checked != true)
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

            if(c==140 && radioButton5.Checked == true)
            {
                z = 2;
                label13.Text = "答對2題";

            }
            if(c!=140 && radioButton5.Checked == true)
            {
                z = 1;
                label13.Text = "答對1題";
                textBox3.BackColor = Color.Red;
            }
            if(c==140 && radioButton5.Checked !=true)
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

            if(d==0)
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

            if(f==150 && radioButton9.Checked ==true)
            {
                k = 2;
                label15.Text = "答對2題";

            }
            if(f!=150 && radioButton9.Checked == true)
            {
                k = 1;
                label15.Text = "答對1題";
                textBox5.BackColor = Color.Red;
            }
            if(f==150 && radioButton9.Checked!=true)
            {
                k = 1;
                label15.Text = "答對1題";
                radioButton10.BackColor = Color.Red;
            }
            else
            {
                k = 0;
                label15.Text = "答對0題";
                textBox5.BackColor = Color.Red;
                radioButton10.BackColor = Color.Red;
            }

            if(g==180 && radioButton12.Checked ==true)
            {
                l = 2;
                label16.Text = "答對2題";

            }
            if(g!=180 && radioButton12.Checked ==true)
            {
                l = 1;
                label16.Text = "答對1題";
                textBox6.BackColor = Color.Red;
            }
            if(g==180 && radioButton12.Checked !=true)
            {
                l = 1;
                label16.Text = "答對1題";
                radioButton11.BackColor = Color.Red;
            }
            else
            {
                l = 0;
                label16.Text = "答對0題";
                textBox6.BackColor = Color.Red;
                radioButton11.BackColor = Color.Red;
            }

            if(h==120 && radioButton14.Checked == true)
            {
                o = 2;
                label17.Text = "答對2題";
            }
            if(h!=120 && radioButton14.Checked ==true)
            {
                o = 1;
                label17.Text = "答對1題";
                textBox7.BackColor = Color.Red;
            }
            if(h==120 && radioButton14.Checked !=true)
            {
                o = 1;
                label17.Text = "答對1題";
                radioButton13.BackColor = Color.Red;
            }
            else
            {
                o = 0;
                label17.Text = "答對0題";
                radioButton13.BackColor = Color.Red;
                textBox7.BackColor = Color.Red;
            }

            if(i==230 && radioButton15.Checked ==true)
            {
                p = 2;
                label18.Text = "答對2題";
            }
            if(i!=230 && radioButton15.Checked ==true)
            {
                p = 1;
                label18.Text = "答對1題";
                textBox8.BackColor = Color.Red;
            }
            if(i==230 && radioButton15.Checked!=true)
            {
                p = 1;
                label18.Text = "答對1題";
                radioButton16.BackColor = Color.Red;
            }
            else
            {
                p = 0;
                label18.Text = "答對0題";
                radioButton16.BackColor = Color.Red;
                textBox8.BackColor = Color.Red;
            }

            if(j==300 && radioButton18.Checked ==true)
            {
                q = 2;
                label19.Text = "答對2題";
            }
            if(j!=300 && radioButton18.Checked ==true)
            {
                q = 1;
                label19.Text = "答對1題";
                textBox9.BackColor = Color.Red;
            }
            if(j==300 && radioButton18.Checked ==true)
            {
                q = 1;
                label19.Text = "答對1題";
                radioButton17.BackColor = Color.Red;
            }
            else
            {
                q = 0;
                label19.Text = "答對0題";
                textBox9.BackColor = Color.Red;
                radioButton17.BackColor = Color.Red;
            }
            r = x + y + z + w + k + l + o + q + p;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = (Form2)this.Owner;
            f.StrValue = r.ToString();
            this.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                i = double.Parse(textBox8.Text);
                if (i != 0)
                {
                    radioButton15.Enabled = true;
                    radioButton16.Enabled = true;
                }
                else
                {
                    radioButton15.Checked = false;
                    radioButton16.Checked = false;
                    radioButton15.Enabled = false;
                    radioButton16.Enabled = false;
                }

            }
            catch
            {
                textBox8.Clear();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                h = double.Parse(textBox7.Text);
                if (h != 0)
                {
                    radioButton13.Enabled = true;
                    radioButton14.Enabled = true;
                }
                else
                {
                    radioButton13.Checked = false;
                    radioButton14.Checked = false;
                    radioButton13.Enabled = false;
                    radioButton14.Enabled = false;
                }

            }
            catch
            {
                textBox7.Clear();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                g = double.Parse(textBox6.Text);
                if (g != 0)
                {
                    radioButton11.Enabled = true;
                    radioButton12.Enabled = true;
                }
                else
                {
                    radioButton11.Checked = false;
                    radioButton12.Checked = false;
                    radioButton11.Enabled = false;
                    radioButton12.Enabled = false;
                }

            }
            catch
            {
                textBox6.Clear();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                 f = double.Parse(textBox5.Text);
                if (f != 0)
                {
                    radioButton9.Enabled = true;
                    radioButton10.Enabled = true;
                }
                else
                {
                    radioButton9.Checked = false;
                    radioButton10.Checked = false;
                    radioButton9.Enabled = false;
                    radioButton10.Enabled = false;
                }

            }
            catch
            {
                textBox5.Clear();
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

            }
            catch
            {
                textBox4.Clear();
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
