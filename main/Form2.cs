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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string strValue1, strValue2, strValue3, strValue4, strValue5, strValue6, strValue7, strValue8, strValue9, strValue10;
        public string StrValue
        {
            set
            {
                strValue1 = value;
                strValue2 = value; strValue3 = value; strValue4 = value; strValue5 = value; strValue6 = value; strValue7 = value; strValue8 = value; strValue9 = value; strValue10 = value;
            }
        }

        string a, b, c, d, f, g, h, i, j, k; 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 f = new num1();
            f.Owner = this;
            f.ShowDialog();
            a = strValue1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num2 f = new num2();
            f.Owner = this;
            f.ShowDialog();
            b = strValue2;
            
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            num3 f = new num3();
            f.Owner = this;
            f.ShowDialog();
            c = strValue3;
        }
        int total;
        private void button12_Click(object sender, EventArgs e)
        {
            total = int.Parse(a) + int.Parse(b) + int.Parse(c) + int.Parse(d) + int.Parse(f) + int.Parse(g) + int.Parse(h) + int.Parse(i) + int.Parse(j) + int.Parse(k);
            DialogResult x = MessageBox.Show("請再次確定是否交卷", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if( x ==DialogResult.OK)
            {
                
                label4.Text =  total.ToString() + " 分";
                button2.Enabled = false;
                button3.Enabled = false; button4.Enabled = false; button5.Enabled = false; button6.Enabled = false; button7.Enabled = false; button8.Enabled = false; button9.Enabled = false; button10.Enabled = false; button11.Enabled = false; button12.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num4 f = new num4();
            f.Owner = this;
            f.ShowDialog();
            d = strValue4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num5 q = new num5();
            q.Owner = this;
            q.ShowDialog();
            f = strValue5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num6 f = new num6();
            f.Owner = this;
            f.ShowDialog();
            g = strValue6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num7 f = new num7();
            f.Owner = this;
            f.ShowDialog();
            h = strValue7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num8 f = new num8();
            f.Owner = this;
            f.ShowDialog();
            i = strValue8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num9 f = new num9();
            f.Owner = this;
            f.ShowDialog();
            j = strValue9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num10 f = new num10();
            f.Owner = this;
            f.ShowDialog();
            k = strValue10;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
