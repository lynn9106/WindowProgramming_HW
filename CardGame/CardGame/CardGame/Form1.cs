using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CardGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        string filename = @"..\Debug\card.map";     //檔案路徑
        int[] size = new int[2];
        int round = 1;
        string player = "P1";
        bool First=false;
        int p1, p2, ScoreP1, ScoreP2;
        Card[,] card;



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = false;
            p1 = p2 = ScoreP1 = ScoreP2 = 0;
            P1Label.Text = "P1:" + ScoreP1 + "分";
            P2Label.Text = "P2:" + ScoreP2 + "分";
            roundLabel.Text = "第" + round + "回合 輪到" + player;
        }

        private void StartBtn_Click(object sender, EventArgs e)     //開始按鈕
        {
            StartBtn.Visible = false;
            roundLabel.Visible = true;
            P1Label.Visible = true;
            P2Label.Visible = true;

            StreamReader sr = new StreamReader(filename);           //載入card.map
            string data;
            data = sr.ReadLine();                                   // 讀取一行文字資料
            string[] SIZE=data.Split(' ');
            int a = 0;
            foreach(string s in SIZE)                               //讀取第一行設定卡牌數量
            {
                size[a] = int.Parse(s);
                a++;
            }
            card = new Card[size[0], size[1]];             //建立卡牌(button)
            for (int i=0;i<size[0];i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    card[i, j] = new Card();
                    card[i, j].Size = new Size(300 / size[1]*9/10, 300 / size[0]*9 / 10);
                    card[i, j].Location = new Point(300/size[1]*j+120, 300 / size[0] * i+75);
                    card[i, j].Num1 = i;
                    card[i, j].Num2 = j;
                    card[i, j].Click += new EventHandler(ButtonClick);          //每個button共用click事件
                    this.Controls.Add(card[i, j]);

                }
            }

            int b = 0, c = 0;
            do
            {
                data = sr.ReadLine();                                   //從第二行開始逐行讀取文件，並給定數字
                if (data == null) break;                                //若為NULL，跳出迴圈
                string[] num = data.Split(' ');
                foreach (string s in num)
                {                             
                    card[b, c].number = int.Parse(s);
                    c++;
                    if (c == size[1])
                    {
                        c = 0;
                       b++;
                    }
                }
            }
            while (true);

            roundLabel.Text = "第" + round + "回合 輪到"+player;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Card btn = sender as Card;
            Game(First, card[btn.Num1,btn.Num2]);
            roundLabel.Text = "第" + round + "回合 輪到" + player;
            if (First == false) First = true;                           //判斷為先手或後手點擊
            else First = false;
        }


        int time;
        int h1, k1,h2,k2,remove=0;
        void Game(bool first,Card btn)
        {


            if (first == false)                                     //先手點擊
            {
                p1 = btn.number;
                h1 = btn.Num1;k1 = btn.Num2;                        //紀錄卡牌點數
                btn.showNumber();
                if (round % 2 == 1)                 //奇數回合為P1作先手，點擊後換P2
                    player = "P2";
                else                               //奇數回合為P2作先手，點擊後換P1
                    player = "P1";
            }
            else if(first == true)                                  //後手點擊
            {
                p2 = btn.number;
                h2 = btn.Num1; k2 = btn.Num2;                       //紀錄卡牌點數
                btn.showNumber();
  
                time = 2;
                for (int i = 0; i < size[0]; i++)                   //2秒內無法再點擊卡牌
                {
                    for (int j = 0; j < size[1]; j++)
                    {
                        card[i, j].Enabled = false;
                    }
                }
                timer1.Enabled = true;                      //計時2秒
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;

            if(time==0)                                     //倒數兩秒結束
            {

                if (p1>p2)          //後手較小
                {
                    for (int i = 0; i < size[0]; i++)
                    {
                        for (int j = 0; j < size[1]; j++)
                        {
                            card[i, j].hideNumber();        //將牌再次覆蓋
                            card[i, j].Enabled = true;      //可再次選牌
                        }
                    }
                }
                else            //後手較大
                {
                    for (int i = 0; i < size[0]; i++)
                    {
                        for (int j = 0; j < size[1]; j++)
                        {
                            card[i, j].Enabled = true;      //可再次選牌
                        }
                    }
                    card[h1, k1].Visible = false;       //選中的兩張牌消失
                    card[h2, k2].Visible = false;
                    remove += 2;                    //紀錄目前丟了幾張牌
                    int get = p2 - p1;
                    if (round % 2 == 1)             //奇數回合P2為後手可得分
                        ScoreP2 += get;
                    else                             //偶數回合P1為後手可得分
                        ScoreP1 += get;
                }
                P1Label.Text = "P1:" + ScoreP1 + "分";
                P2Label.Text = "P2:" + ScoreP2 + "分";

                if (remove==(size[0]*size[1])/2)    //若已丟掉一半的牌，則遊戲結束
                {
                    timer1.Enabled = false;
                    DialogResult result;
                    if(ScoreP1>ScoreP2)
                        result = MessageBox.Show("遊戲結束 P1獲勝", "", MessageBoxButtons.OK);
                    else if(ScoreP1 < ScoreP2)
                        result = MessageBox.Show("遊戲結束 P2獲勝", "", MessageBoxButtons.OK);
                    else
                        result = MessageBox.Show("遊戲結束 此局平手", "", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                round++;
                roundLabel.Text = "第" + round + "回合 輪到" + player;
                timer1.Enabled = false;
            }
        }

    }
}
