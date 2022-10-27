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
    public partial class num8 : Form
    {
        public num8()
        {
            InitializeComponent();
        }

        private void num8_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\picture\8.jpg");
            label1.Text = "If the maximum force that any member can support is 8 kN in tension and 6 kN in compression, determine the maximum force P that can be supported at joint D.";
        }
        double a;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);

            }
            catch
            {
                textBox1.Clear();
            }
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }
        int x;
        private void button1_Click(object sender, EventArgs e)
        {
            if(a==5.2)
            {
                x = 1;
                label4.Text = "答對一題";
            }
            else
            {
                x = 0;
                label4.Text = "答對0題";
                textBox1.BackColor = Color.Red;
                    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = (Form2)this.Owner;
            f.StrValue = x.ToString();
            this.Close();
        }
    }
    
}
