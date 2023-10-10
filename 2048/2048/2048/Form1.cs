using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[,] b = new Button[4, 6];         //建立buttonArray作為俄羅斯方塊
        int PutNum,rand,Score,time;
        Random randnum = new Random();
        bool easy;


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;     //(1秒)
            timer1.Enabled = false;
            btnArray(panel1, b);
            PutNum = Rand();    //隨機選取2,4,8
            Score =0;
            time = 3;
            ScoreLabel.Text = "你的分數:" + Score;
            NumLabel.Text = "當前數字:" + PutNum;
            timeLabel.Text = "倒數計時:" + time;
        }

        protected Button[,] btnArray(Panel panel, Button[,] b)                 //在Panel中建立ButtonArray(方塊)
        {
            panel.Width = 200;
            panel.Height = 300;
            panel.Location = new Point(30, 30);
            int w = panel.Width / 4;
            int h = panel.Height / 6;
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    b[i, j] = new Button();
                    b[i, j].SetBounds(w * i, h * j, w * 9 / 10, h * 9 / 10);   //(starting point X, starting point Y, width, heighth)
                    panel.Controls.Add(b[i, j]);
                    b[i, j].Visible = false;                                   //未收到指令不顯示方塊
                }
            }
            return b;
        }

        private void easybtn_Click(object sender, EventArgs e)
        {
            easybtn.Visible = false;
            normbtn.Visible = false;
            ScoreLabel.Visible = true;
            NumLabel.Visible = true;
            panel1.Visible = true;
            easy = true;            //判斷為簡單模式
        }

        private void normbtn_Click(object sender, EventArgs e)
        {
            easybtn.Visible = false;
            normbtn.Visible = false;
            timeLabel.Visible = true;
            ScoreLabel.Visible = true;
            NumLabel.Visible = true;
            panel1.Visible = true;
            easy = false;           //判斷為普通模式
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

                switch (e.KeyCode)          // 根據e.KeyCode分別執行
                {
                    case Keys.Q:
                        Put('Q');
                        break;
                    case Keys.W:
                        Put('W');
                        break;
                    case Keys.E:
                        Put('E');
                        break;
                    case Keys.R:
                        Put('R');
                        break;                   
                }
                if (easy == true)               //簡單模式可輸入ASD更換方塊
                {
                    switch (e.KeyCode)          // 根據e.KeyCode分別執行
                    {
                        case Keys.A:
                            PutNum = 2;
                            break;
                        case Keys.S:
                            PutNum = 4;
                            break;
                        case Keys.D:
                            PutNum = 8;
                            break;
                    }
                }
                else                            //普通模式須計時且不可更換方塊
                {
                    timer1.Enabled = true;          //開始計時
                    time = 3;
                }

            ScoreLabel.Text = "你的分數:" + Score;
            NumLabel.Text = "當前數字:" + PutNum;
            timeLabel.Text = "倒數計時:" + time;
        }

        private void Put(char c)                //方塊掉落時的情況及變化
        {
            try
            {
                string PN = Convert.ToString(PutNum);
                int i = 5;
                switch (c)
                {
                    case 'Q':
                        while (i >= 0 && b[0, i].Visible == true)               //如果方塊不超過六個，且i位置有方塊存在，則往上移一格(i--)
                        {
                            i--;
                        }
                        if (i < 5 && PN == b[0, i + 1].Text)                //若掉落的方塊與下方數值相同，使下方方塊數值*2
                        {
                            b[0, i + 1].Text = Convert.ToString(PutNum * 2);
                            i++;
                            while (i < 5 && b[0, i].Text == b[0, i + 1].Text)       //改變數值後的方塊與其下方方塊數值相同，再使下方方塊數值*2
                            {
                                b[0, i].Visible = false;
                                b[0, i + 1].Text = Convert.ToString(int.Parse(b[0, i + 1].Text) * 2);
                                i++;
                            }
                        }
                        else                                           //皆無以上情況，使方塊直接掉落
                        {
                            b[0, i].Visible = true;
                            b[0, i].Text = PN;
                        }
                        break;
                    case 'W':
                        while (i >= 0 && b[1, i].Visible == true)    //如果方塊不超過六個，且i位置有方塊存在，則往上移一格(i--)
                        {
                            i--;
                        }
                        if (i < 5 && PN == b[1, i + 1].Text)                //若掉落的方塊與下方數值相同，使下方方塊數值*2
                        {
                            b[1, i + 1].Text = Convert.ToString(PutNum * 2);
                            i++;
                            while (i < 5 && b[1, i].Text == b[1, i + 1].Text) //改變數值後的方塊與其下方方塊數值相同，再使下方方塊數值*2
                            {
                                b[1, i].Visible = false;
                                b[1, i + 1].Text = Convert.ToString(int.Parse(b[1, i + 1].Text) * 2);
                                i++;
                            }
                        }
                        else                                           //皆無以上情況，使方塊直接掉落
                        {
                            b[1, i].Visible = true;
                            b[1, i].Text = PN;
                        }
                        break;
                    case 'E':
                        while (i >= 0 && b[2, i].Visible == true)    //如果方塊不超過六個，且i位置有方塊存在，則往上移一格(i--)
                        {
                            i--;
                        }
                        if (i < 5 && PN == b[2, i + 1].Text)                //若掉落的方塊與下方數值相同，使下方方塊數值*2
                        {
                            b[2, i + 1].Text = Convert.ToString(PutNum * 2);
                            i++;
                            while (i < 5 && b[2, i].Text == b[2, i + 1].Text) //改變數值後的方塊與其下方方塊數值相同，再使下方方塊數值*2
                            {
                                b[2, i].Visible = false;
                                b[2, i + 1].Text = Convert.ToString(int.Parse(b[2, i + 1].Text) * 2);
                                i++;
                            }
                        }
                        else                                           //皆無以上情況，使方塊直接掉落
                        {
                            b[2, i].Visible = true;
                            b[2, i].Text = PN;
                        }
                        break;
                    case 'R':
                        while (i >= 0 && b[3, i].Visible == true)    //如果方塊不超過六個，且i位置有方塊存在，則往上移一格(i--)
                        {
                            i--;
                        }
                        if (i < 5 && PN == b[3, i + 1].Text)                //若掉落的方塊與下方數值相同，使下方方塊數值*2
                        {
                            b[3, i + 1].Text = Convert.ToString(PutNum * 2);
                            i++;
                            while (i < 5 && b[3, i].Text == b[3, i + 1].Text) //改變數值後的方塊與其下方方塊數值相同，再使下方方塊數值*2
                            {
                                b[3, i].Visible = false;
                                b[3, i + 1].Text = Convert.ToString(int.Parse(b[3, i + 1].Text) * 2);
                                i++;
                            }
                        }
                        else                                           //皆無以上情況，使方塊直接掉落
                        {
                            b[3, i].Visible = true;
                            b[3, i].Text = PN;
                        }
                        break;
                }

                if (b[0, i].Text == b[1, i].Text && b[0, i].Text == b[2, i].Text && b[0, i].Text == b[3, i].Text) //若同列值相同，則得分，並往下降
                {
                    b[0, i].Visible = false;
                    b[1, i].Visible = false;
                    b[2, i].Visible = false;
                    b[3, i].Visible = false;
                    Score += int.Parse(b[0, i].Text) * int.Parse(b[0, i].Text);

                    for (int x = 0; x < 4; x++)
                    {
                        for (int y = i - 1; y >= 0; y--)
                        {
                            b[x, y + 1].Visible = b[x, y].Visible;
                            b[x, y + 1].Text = b[x, y].Text;
                        }
                        b[x, 0].Visible = false;
                        b[x, 0].Text = "";
                    }
                    Plus();         //當某列消去時，重新判斷各行中是否有相同的值須做相加

                }


                PutNum = Rand();
                return;
            }
            catch (IndexOutOfRangeException)     //若方塊超出Array，則跳出messagebox並在按下確認後結束程式
            {
                timer1.Enabled = false;         //停止計時
                DialogResult result;
                result = MessageBox.Show("遊戲結束!!!\n你的分數:" + Score, "", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
                return;
            }
        }

        private int Rand()      //隨機取得2,4,8
        {
            rand = randnum.Next(3);
            if (rand == 0)
                PutNum = 2;
            else if (rand == 1)
                PutNum = 4;
            else
                PutNum = 8;
            return PutNum;
        }

        private void timer1_Tick(object sender, EventArgs e)    //每隔三秒重新倒數，並在W行落下方塊
        {
            if (time == 1)
            {
                Put('W');
                time = 4;
            }
            time--;
            ScoreLabel.Text = "你的分數:" + Score;
            NumLabel.Text = "當前數字:" + PutNum;
            timeLabel.Text = "倒數計時:" + time;

        }


        private void Plus()     //當某列消去時，重新判斷各行中是否有相同的值須做相加
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 4; y >= 0; y--)
                {
                    while (b[x, y].Text == b[x, y + 1].Text && b[x, y].Text != "") //若下方遇相同值的方塊
                    {
                        for (int down = y; down > 0; down--)        //將該行所有方塊向下移一格
                        {
                            b[x, down].Visible = b[x, down - 1].Visible;
                            b[x, down].Text = b[x, down - 1].Text;
                        }

                        b[x, y + 1].Text = Convert.ToString(int.Parse(b[x, y + 1].Text) * 2);       //並將其下方方塊的值乘2

                        if (y<4&&b[x, y+1].Text == b[x, y + 2].Text && b[x, y].Text != "") //改變後下方若產生等值方塊再重複Plus()
                            Plus();
                    }

                }
            }
            return;
        }



















    }
}
