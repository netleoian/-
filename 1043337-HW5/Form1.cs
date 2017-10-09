using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1043337_HW5
{
    public partial class Form1 : Form
    {
        PictureBox[] img = new PictureBox[17];
        Image[] tmp = new Image[17];
        int[] use = new int[9] { 2, 2, 2, 2, 2, 2, 2, 2,2};
        int time1 = 0;
        int lastuse=0;
        int playtime=0;
        bool[] open = new bool[17] { false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false};
        void ramdom(){
            Random x=new Random();
            int tmpx;
            for(int i=1;i<=16;i++){
                tmpx = x.Next(1, 9);
                while (use[tmpx] - 1 < 0) {//隨機圖片
                    tmpx = x.Next(1, 9);
                }
                use[tmpx] -= 1;
                switch (tmpx)//先放入隨機的圖片
                { 
                    case 1:
                    tmp[i] = Properties.Resources._8_1;
                    tmp[i].Tag = 1;
                    break;
                    case 2:
                    tmp[i] = Properties.Resources._8_2;
                    tmp[i].Tag = 2;
                    break;
                    case 3:
                    tmp[i] = Properties.Resources._8_3;
                    tmp[i].Tag = 3;
                    break;
                    case 4:
                    tmp[i] = Properties.Resources._8_4;
                    tmp[i].Tag = 4;
                    break;
                    case 5:
                    tmp[i] = Properties.Resources._8_5;
                    tmp[i].Tag = 5;
                    break;
                    case 6:
                    tmp[i] = Properties.Resources._8_6;
                    tmp[i].Tag =6;
                    break;
                    case 7:
                    tmp[i] = Properties.Resources._8_7;
                    tmp[i].Tag = 7;
                    break;
                    case 8:
                    tmp[i] = Properties.Resources._8_8;
                    tmp[i].Tag = 8;
                    break;
                }
        }
            for (int i = 1; i <= 16; i++)
            {
                img[i].Image = Properties.Resources._8_0;//覆蓋所有排
                open[i] = false;
            }
            for (int i = 1; i <= 8; i++)//初始化 已經使用
                use[i]=2;
        }
        public Form1()
        {
            InitializeComponent();
            img[1] = pictureBox1;
            img[2] = pictureBox2;
            img[3] = pictureBox3;
            img[4] = pictureBox4;
            img[5] = pictureBox5;
            img[6] = pictureBox6;
            img[7] = pictureBox7;
            img[8] = pictureBox8;
            img[9] = pictureBox9;
            img[10] = pictureBox10;
            img[11] = pictureBox11;
            img[12] = pictureBox12;
            img[13] = pictureBox13;
            img[14] = pictureBox14;
            img[15] = pictureBox15;
            img[16] = pictureBox16;
       
           
            ramdom();
        }

        bool check()
        {
            for (int i = 1; i <= 16; i++)
            {
                if (open[i] == false)
                    return false;
            }
            return true;
        }
        void judge(int a){
            if (open[a])
                return;
            
            open[a]= true;//OPEN為正確
            img[a].Image = tmp[a];
            if (lastuse == 0)//如果等於0就沒事 就新增
            {
                lastuse = a;
            }
            else {
                string one = tmp[lastuse].Tag + "0";
                string two = tmp[a].Tag + "0";
                if (one ==two)
                {//相等         
                    lastuse = 0;//初始上一個
                }
                else
                {//不相等
                    open[a] = open[lastuse] = false;
                    for (int i = 1; i <= 16; i++)
                        img[i].Enabled = false;
                    timer1.Enabled = true;
                    lastuse = 0;
                }
            }
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
           
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            judge(1);
            if (check()) {//如果全部完成
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            judge(2);
      
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            judge(3);

            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            judge(4);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            judge(8);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            judge(6);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            judge(5);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            judge(12);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            judge(11);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            judge(10);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            judge(9);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            judge(16);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            judge(15);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            judge(14);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            judge(13);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            judge(7);
            
            if (check())
            {
                timer2.Stop();
                label1.Text += " SUCCESS!";
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            for (int i = 1; i <= 16; i++)
            {
                img[i].Enabled = true;
                if (open[i])
                    img[i].Image = tmp[i];
                else {
                    img[i].Image = Properties.Resources._8_0;
                }
            }
     
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             label1.Text=playtime+"Seconds";
             playtime++;
            
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playtime = 0;
            ramdom();
     
        }

       
    }
}
