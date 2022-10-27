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
    public partial class Form14 : Form
    {
        Graphics gg;
        int[] drawxi = new int[19];// 畫上去的x座標起點
        int[] drawyi = new int[19];// 畫上去的y座標起點
        int[] drawxf = new int[19];// 畫上去的x座標終點
        int[] drawyf = new int[19];// 畫上去的y座標終點
        int[] pointxi = new int[19];//輸入的x座標起點
        int[] pointyi = new int[19];//輸入的y座標起點
        int[] pointxf = new int[19];//輸入的x座標終點
        int[] pointyf = new int[19];//輸入的y座標終點
        int[] property = new int[19];//桿件=0  外力=1
        int[] bacement = new int[19];//基底=1 非基底=0
        string[] pinrocker = new string[19];
        int xiin;
        int yiin;
        int xfin;
        int yfin;
        int xitr;
        int yitr;
        int xftr;
        int yftr;
        int count = 0;
        int force = -1;
        int bace = 0;
        int pin = 0;
        int rocker = 0;
        string key = "blank";
        string warm = "blanl";
        string gate = "blank";
        public Form14()
        {
            InitializeComponent();
            gg = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (force == -1)
                MessageBox.Show("請選擇是桿件或是外力", "請選擇", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                    MessageBox.Show("請填完所有空格", "請填完整", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                {
                    if (warm != "yes")
                        MessageBox.Show("固定選項不正確", "請重新選擇", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                    {
                        if (key == "none")
                        {
                            if (System.Convert.ToInt32(textBox2.Text) != 0 & System.Convert.ToInt32(textBox4.Text) != 0)
                                gate = "open";
                        }
                        if (key == "pin" || key == "rocker")
                        {
                            if (System.Convert.ToInt32(textBox2.Text) == 0 || System.Convert.ToInt32(textBox4.Text) == 0)
                                gate = "open";
                        }
                        if (force == 1)
                            gate = "open";
                        if (pin == 1 & key == "pin" & force == 0)
                        {
                            MessageBox.Show("只能有一個pin", "請重新選擇", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            gate = "close";
                        }
                        if (rocker == 1 & key == "rocker" & force == 0)
                        {
                            MessageBox.Show("只能有一個rocker", "請重新選擇", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            gate = "close";
                        }

                        if (gate != "open")
                            MessageBox.Show("固定選項不正確", "請重新選擇", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        else
                        {
                            xiin = System.Convert.ToInt32(textBox1.Text);
                            xitr = (xiin + 20);
                            yiin = System.Convert.ToInt32(textBox2.Text);
                            yitr = (420 - yiin);
                            xfin = System.Convert.ToInt32(textBox3.Text);
                            xftr = (xfin + 20);
                            yfin = System.Convert.ToInt32(textBox4.Text);
                            yftr = (420 - yfin);

                            if (System.Convert.ToInt32(textBox2.Text) == 0 || System.Convert.ToInt32(textBox4.Text) == 0)//是否為基底
                                bace = 1;
                            else
                                bace = 0;




                            drawxi[count] = xitr;
                            drawyi[count] = yitr;
                            drawxf[count] = xftr;
                            drawyf[count] = yftr;

                            pointxi[count] = xiin;
                            pointyi[count] = yiin;
                            pointxf[count] = xfin;
                            pointyf[count] = yfin;

                            property[count] = force;//桿件=0  外力=1
                            bacement[count] = bace;//基底=1 非基底=0
                            pinrocker[count] = key;// pin?? rocker?? none??
                            if (force == 1)
                                pinrocker[count] = "none";

                            Pen pp = new Pen(Color.Black, 8);// 畫出座標軸
                            pp.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            gg.DrawLine(pp, 20, 420, 20, 20);
                            gg.DrawLine(pp, 20, 420, 820, 420);
                            if (key == "pin" & force == 0)
                                pin++;
                            if (key == "rocker" & force == 0)
                                rocker++;


                            for (int number = 0; number <= count; number++)
                            {
                                if (property[number] == 0)// 桿件?? 力??
                                    pp = new Pen(Color.Blue, 6);
                                else
                                {
                                    pp.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                                    pp = new Pen(Color.Red, 6);

                                }
                                gg.DrawLine(pp, drawxi[number], drawyi[number], drawxf[number], drawyf[number]);

                                if (bacement[number] == 1)
                                {
                                    if (drawyi[number] == 420)
                                    {
                                        if (pinrocker[number] == "pin")
                                        {
                                            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                                            System.Drawing.Graphics formGraphics;
                                            formGraphics = this.CreateGraphics();
                                            formGraphics.FillRectangle(myBrush, new Rectangle(drawxi[number] - 5, drawyi[number] - 10, 20, 20));

                                        }
                                        if (pinrocker[number] == "rocker")
                                        {
                                            Brush bb = new SolidBrush(Color.Pink);
                                            gg.FillEllipse(bb, drawxi[number] - 5, drawyi[number] - 5, 20, 20);

                                        }
                                    }
                                    else
                                    {
                                        if (pinrocker[number] == "pin")
                                        {
                                            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                                            System.Drawing.Graphics formGraphics;
                                            formGraphics = this.CreateGraphics();
                                            formGraphics.FillRectangle(myBrush, new Rectangle(drawxf[number] - 5, drawyf[number] - 10, 20, 20));

                                        }
                                        if (pinrocker[number] == "rocker")
                                        {
                                            Brush bb = new SolidBrush(Color.Pink);
                                            gg.FillEllipse(bb, drawxf[number] - 5, drawyf[number] - 5, 20, 20);

                                        }
                                    }

                                }
                            }




                            if (count >= 0)
                                label1.Text = "第1條  ( " + pointxi[0].ToString() + " , " + pointyi[0].ToString() + " )    " + "( " + pointxf[0].ToString() + " , " + pointyf[0].ToString() + " )";
                            if (count >= 1)
                                label6.Text = "第2條  ( " + pointxi[1].ToString() + " , " + pointyi[1].ToString() + " )    " + "( " + pointxf[1].ToString() + " , " + pointyf[1].ToString() + " )";
                            if (count >= 2)
                                label7.Text = "第3條  ( " + pointxi[2].ToString() + " , " + pointyi[2].ToString() + " )    " + "( " + pointxf[2].ToString() + " , " + pointyf[2].ToString() + " )";
                            if (count >= 3)
                                label8.Text = "第4條  ( " + pointxi[3].ToString() + " , " + pointyi[3].ToString() + " )    " + "( " + pointxf[3].ToString() + " , " + pointyf[3].ToString() + " )";
                            if (count >= 4)
                                label9.Text = "第5條  ( " + pointxi[4].ToString() + " , " + pointyi[4].ToString() + " )    " + "( " + pointxf[4].ToString() + " , " + pointyf[4].ToString() + " )";
                            if (count >= 5)
                                label10.Text = "第6條  ( " + pointxi[5].ToString() + " , " + pointyi[5].ToString() + " )    " + "( " + pointxf[5].ToString() + " , " + pointyf[5].ToString() + " )";
                            if (count >= 6)
                                label11.Text = "第7條  ( " + pointxi[6].ToString() + " , " + pointyi[6].ToString() + " )    " + "( " + pointxf[6].ToString() + " , " + pointyf[6].ToString() + " )";
                            if (count >= 7)
                                label12.Text = "第8條  ( " + pointxi[6].ToString() + " , " + pointyi[6].ToString() + " )    " + "( " + pointxf[6].ToString() + " , " + pointyf[6].ToString() + " )";
                            if (count >= 8)
                                label17.Text = "第9條  ( " + pointxi[6].ToString() + " , " + pointyi[6].ToString() + " )    " + "( " + pointxf[6].ToString() + " , " + pointyf[6].ToString() + " )";
                            if (count >= 9)
                                label18.Text = "第10條  ( " + pointxi[6].ToString() + " , " + pointyi[6].ToString() + " )    " + "( " + pointxf[6].ToString() + " , " + pointyf[6].ToString() + " )";
                            if (count >= 10)
                                label22.Text = "第11條  ( " + pointxi[6].ToString() + " , " + pointyi[6].ToString() + " )    " + "( " + pointxf[6].ToString() + " , " + pointyf[6].ToString() + " )";

                            count++;
                            gate = "blank";
                            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();


                        }
                    }
                }
            }
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label12.Text = "";
            label17.Text = "";
            label18.Text = "";
            label22.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            force = 0; //桿件
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            force = 1;  //外力
            warm = "yes";
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (force == 0)
            {
                if (radioButton4.Checked == true)
                {
                    if (System.Convert.ToInt32(textBox2.Text) != 0 & System.Convert.ToInt32(textBox4.Text) != 0)
                    {
                        MessageBox.Show("非基底不能用rocker固定", "請重新選擇", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        warm = "no";
                    }
                    else
                    {
                        warm = "yes";
                        key = "rocker";
                    }
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (force == 0)
            {
                if (radioButton3.Checked == true)
                {
                    if (System.Convert.ToInt32(textBox2.Text) != 0 & System.Convert.ToInt32(textBox4.Text) != 0)
                    {
                        MessageBox.Show("非基底不能用pin固定", "請重新選擇", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        warm = "no";
                    }
                    else
                    {
                        warm = "yes";
                        key = "pin";
                    }
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (force == 0)
            {
                if (radioButton5.Checked == true)
                {
                    if (System.Convert.ToInt32(textBox2.Text) == 0 || System.Convert.ToInt32(textBox4.Text) == 0)
                    {
                        MessageBox.Show("基底不能沒有固定", "請重新選擇", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        warm = "no";
                    }
                    else
                    {
                        warm = "yes";
                        key = "none";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int xa = 0;
            int xb = 0;
            int ya;
            int yb;
            int fxi = 0;//外力起點 x座標
            int fm = 0;//外力大小
            int fb = 0;
            int fa = 0;
            int c = 0;
            int d = 0;
            int g = -1;
            int[] forcex = new int[19];
            int[] forcem = new int[19];
            int[] forcexm = new int[19];
            int sumxm = 0;
            int summ = 0;
            int summx = 0;
            int finalx = 0;
            string where = "none";
            int basenumber = pin + rocker;


            if (basenumber == 2)
            {
                for (int number = 0; number <= count - 1; number++)
                {
                    if (pointyi[number] == 0)
                    {
                        if (property[number] == 0)
                        {
                            xa = pointxi[number];
                            c = number + 1;
                            if (pinrocker[number] == "pin")
                                where = "a";
                        }
                    }
                    if (pointyf[number] == 0)
                    {
                        if (property[number] == 0)
                        {
                            xb = pointxf[number];
                            d = number + 1;
                            if (pinrocker[number] == "pin")
                                where = "b";
                        }
                    }
                    if (property[number] == 1)
                    {
                        g++;
                        forcex[g] = pointxi[number];
                        forcem[g] = pointyf[number] - pointyi[number];
                        forcexm[g] = pointxf[number] - pointxi[number];

                    }
                }

                for (int z = 0; z <= g; z++)
                {
                    sumxm = sumxm + forcex[z] * forcem[z];
                    summ = summ + forcem[z];
                    summx = summx + forcexm[z];
                }
                if (summ != 0)
                    finalx = sumxm / summ;

                if (xb - xa != 0)
                {
                    fb = (finalx - xa) * summ / (xb - xa);
                }

                fa = summ - fb;
                label13.Text = "第" + c.ToString() + "條桿件 y方向受力" + fa.ToString() + "N";
                label15.Text = "第" + d.ToString() + "條桿件 y方向受力" + fb.ToString() + "N";
                if (where == "a")
                    label14.Text = "第" + c.ToString() + "條桿件 x方向受力" + summx.ToString() + "N";
                if (where == "b")
                    label16.Text = "第" + d.ToString() + "條桿件 x方向受力" + summx.ToString() + "N";
            }

            if (basenumber == 1 & pin == 1)
            {
                for (int number = 0; number <= count - 1; number++)
                {
                    if (pointyi[number] == 0)
                    {
                        if (property[number] == 0)
                        {
                            xa = pointxi[number];
                            c = number + 1;

                        }
                    }
                    if (pointyf[number] == 0)
                    {
                        if (property[number] == 0)
                        {
                            xb = pointxf[number];
                            d = number + 1;

                        }
                    }
                    if (property[number] == 1)
                    {
                        g++;
                        forcex[g] = pointxi[number];
                        forcem[g] = pointyf[number] - pointyi[number];
                        forcexm[g] = pointxf[number] - pointxi[number];

                    }
                }
                for (int z = 0; z <= g; z++)
                {
                    sumxm = sumxm + forcex[z] * forcem[z];
                    summ = summ + forcem[z];
                    summx = summx + forcexm[z];
                }
                label13.Text = "第1條桿件 y方向受力" + summ.ToString() + "N";
                label14.Text = "第1條桿件 x方向受力" + summx.ToString() + "N";
            }
            if (basenumber == 1 & rocker == 1)
            {
                for (int number = 0; number <= count - 1; number++)
                {
                    if (pointyi[number] == 0)
                    {
                        if (property[number] == 0)
                        {
                            xa = pointxi[number];
                            c = number + 1;

                        }
                    }
                    if (pointyf[number] == 0)
                    {
                        if (property[number] == 0)
                        {
                            xb = pointxf[number];
                            d = number + 1;

                        }
                    }
                    if (property[number] == 1)
                    {
                        g++;
                        forcex[g] = pointxi[number];
                        forcem[g] = pointyf[number] - pointyi[number];
                        forcexm[g] = pointxf[number] - pointxi[number];

                    }
                }
                for (int z = 0; z <= g; z++)
                {
                    sumxm = sumxm + forcex[z] * forcem[z];
                    summ = summ + forcem[z];
                    summx = summx + forcexm[z];
                }
                label13.Text = "第1條桿件 y方向受力" + summ.ToString() + "N";
                label14.Text = "第1條桿件 x方向受力" + summx.ToString() + "N  但無法有反作用力";
            }

            if (basenumber == 0)
                MessageBox.Show("無法計算", "請重新輸入", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 f = new Form15();
            f.Show(this);
        }
    }
}
