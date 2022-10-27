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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            label1.Text = "以下將會有10題有關truss結構的計算題，請以最快的時間內全部解出，計分方式如下：\n一共有119個空格，答對一個即獲得1分，總分119分\n按下開始即作答！";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult m = MessageBox.Show("請再次確認是否開始", "注意！", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if( m == DialogResult.OK)
            {
                this.Close();
                Form2 f = new Form2();
                f.Show();
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
