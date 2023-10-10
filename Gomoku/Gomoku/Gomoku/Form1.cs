using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Chess[,] chess=new Chess[19,19];
        string P1Job = "戰士", P2Job="戰士";
        int round = 1;
        Character p1Character = new Character();
        Character p2Character = new Character();
        string decide;
        bool PUT = false;
        bool[,] count = new bool[19, 19];
        bool[,] mark1 = new bool[19, 19];
        bool[,] mark2 = new bool[19, 19];

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(900,650);
            StartBtn.Location = new Point(370,440);
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    count[i, j] = false;
                    mark1[i, j] = false;
                    mark2[i, j] = false;
                    chess[i, j] = new Chess();
                    chess[i, j].Size = new Size(21, 21);
                    chess[i, j].Location = new Point(21 * j + 230, 21 * i + 30);
                    chess[i, j].Num1 = i;
                    chess[i, j].Num2 = j;
                    chess[i, j].Visible = false;
                    chess[i, j].Click += new EventHandler(ButtonClick);          //每個button共用click事件
                    this.Controls.Add(chess[i, j]);
                }
            }
        }


        private void StartBtn_Click(object sender, EventArgs e)
        {
            WarBtn1.Visible = false;
            WarBtn2.Visible = false;
            WitBtn1.Visible = false;
            WitBtn2.Visible = false;
            ArcBtn1.Visible = false;
            ArcBtn2.Visible = false;
            StartBtn.Visible = false;

            UsualBtn1.Visible = true;
            UsualBtn2.Visible = true;
            LRBtn1.Visible = true;
            LRBtn2.Visible = true;
            UDBtn1.Visible = true;
            UDBtn2.Visible = true;
            CovBtn1.Visible = true;
            CovBtn2.Visible = true;

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    chess[i, j].Visible = true;
                }
            }

            if (P1Job == "戰士")                  //判斷p1與p2的職業
            {
                Warrior warrior1 = new Warrior();
                ChessRemain1(warrior1);
                p1Character = warrior1;
            }
            else if (P1Job == "法師")
            {
                Witcher witcher1 = new Witcher();
                ChessRemain1(witcher1);
                p1Character = witcher1;
            }
            else if(P1Job=="弓箭手")
            {
                Archer archer1 = new Archer();
                ChessRemain1(archer1);
                p1Character = archer1;
            }
            if (P2Job == "戰士")
            {
                Warrior warrior2 = new Warrior();
                warrior2.numD += 1;
                ChessRemain2(warrior2);
                p2Character = warrior2;
            }
            else if (P2Job == "法師")
            {
                Witcher witcher2 = new Witcher();
                witcher2.numD += 1;
                ChessRemain2(witcher2);
                p2Character = witcher2;
            }
            else if (P2Job == "弓箭手")
            {
                Archer archer2 = new Archer();
                archer2.numD += 1;
                ChessRemain2(archer2);
                p2Character = archer2;
            }


            UsualBtn2.Enabled = false;
            LRBtn2.Enabled = false;
            UDBtn2.Enabled = false;
            CovBtn2.Enabled = false;
        }

        //顯示剩餘棋子
        void ChessRemain1(Character character)
        {
            LRBtn1.Text = "橫向棋子:" + character.numB+"顆";
            UDBtn1.Text = "縱向棋子:" + character.numC + "顆";
            CovBtn1.Text = "覆蓋棋子:" + character.numD + "顆";

            if (character.numB == 0) LRBtn1.Enabled = false;
            if (character.numC == 0) UDBtn1.Enabled = false;
            if (character.numD == 0) CovBtn1.Enabled = false;
        }
        void ChessRemain2(Character character)
        {
            LRBtn2.Text = "橫向棋子:" + character.numB + "顆";
            UDBtn2.Text = "縱向棋子:" + character.numC + "顆";
            CovBtn2.Text = "覆蓋棋子:" + character.numD + "顆";

            if (character.numB == 0) LRBtn2.Enabled = false;
            if (character.numC == 0) UDBtn2.Enabled = false;
            if (character.numD == 0) CovBtn2.Enabled = false;
        }


        //按下button
        private void ButtonClick(object sender, EventArgs e)
        {
            Chess btn = sender as Chess;
            Put(decide, round,btn,chess);
            if (PUT == true)                //判斷是否成功放下棋子
            {
                ChessRemain1(p1Character);
                ChessRemain2(p2Character);
            }
            else                 
                return;


            if (round%2==1)                         //判斷是否連線
                judge(btn.Num1, btn.Num2, chess, mark1);
            else
                judge(btn.Num1, btn.Num2, chess, mark2);

            if (win == true)                    //若連線成功，依照回合判斷贏家
            {
                DialogResult result;
                if (round % 2 == 1)
                    result = MessageBox.Show("遊戲結束 P1獲勝", "", MessageBoxButtons.OK);
                else
                    result = MessageBox.Show("遊戲結束 P2獲勝", "", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                round++;
                return;
            }

        }


        //放下棋子
        void Put(string Decide, int round, Chess btn, Chess[,] chess)
        {
            if (round % 2 == 1)
            {
                if (chess[btn.Num1, btn.Num2].BackColor == DefaultBackColor)
                {
                    chess[btn.Num1, btn.Num2].BackColor = p1Character.P1color;
                    mark1[btn.Num1, btn.Num2] = true;
                    if (Decide == "B" && btn.Num2 + 1 < 19&& p1Character.numB > 0)  
                    {
                        if (chess[btn.Num1, btn.Num2 + 1].BackColor == DefaultBackColor)
                        {
                            chess[btn.Num1, btn.Num2 + 1].BackColor = p1Character.P1color;
                            mark1[btn.Num1, btn.Num2 + 1] = true;
                        }
                        p1Character.numB--;
                    }
                    else if (Decide == "C" && btn.Num1 + 1 < 19&& p1Character.numC > 0)
                    {
                        if (chess[btn.Num1 + 1, btn.Num2].BackColor == DefaultBackColor)
                        {
                            chess[btn.Num1 + 1, btn.Num2].BackColor = p1Character.P1color;
                            mark1[btn.Num1 + 1, btn.Num2] = true;
                        }
                            p1Character.numC--;
                    }
                    else if (Decide == "D"&&p1Character.numD>0)
                            p1Character.numD--;
                }

                else
                {
                    if (Decide == "D"&&p1Character.numD>0)
                    {
                        chess[btn.Num1, btn.Num2].BackColor = p1Character.P1color;
                        mark1[btn.Num1, btn.Num2] = true;
                        mark2[btn.Num1, btn.Num2] = false;
                        p1Character.numD--;
                    }
                    else
                    {
                        PUT = false;
                        return;
                    }

                }

                UsualBtn1.Enabled = false;
                LRBtn1.Enabled = false;
                UDBtn1.Enabled = false;
                CovBtn1.Enabled = false;
                UsualBtn2.Enabled = true;
                LRBtn2.Enabled = true;
                UDBtn2.Enabled = true;
                CovBtn2.Enabled = true;
            }
            else
            {
                if (chess[btn.Num1, btn.Num2].BackColor == DefaultBackColor)
                {
                    chess[btn.Num1, btn.Num2].BackColor = p2Character.P2color;
                    mark2[btn.Num1, btn.Num2] = true;
                        if (Decide == "B"&&btn.Num2+1<19&& p2Character.numB > 0)
                    {
                            if (chess[btn.Num1, btn.Num2 + 1].BackColor == DefaultBackColor)
                            {
                                chess[btn.Num1, btn.Num2 + 1].BackColor = p2Character.P2color;
                                mark2[btn.Num1, btn.Num2 + 1] = true;
                            }
                        p2Character.numB--;
                    }
                    else if (Decide == "C" && btn.Num1 + 1 < 19 && p2Character.numC > 0)
                    {
                            if (chess[btn.Num1 + 1, btn.Num2].BackColor == DefaultBackColor)
                            {
                                chess[btn.Num1 + 1, btn.Num2].BackColor = p2Character.P2color;
                                mark2[btn.Num1 + 1, btn.Num2 ] = true; ;
                            }
                        p2Character.numC--;
                    }
                    else if(Decide=="D" && p2Character.numD > 0)
                        p2Character.numD--;
                }
                else
                {
                    if (Decide == "D" && p2Character.numD > 0)
                    {
                        chess[btn.Num1, btn.Num2].BackColor = p2Character.P2color;
                        mark2[btn.Num1, btn.Num2] = true;
                        mark1[btn.Num1, btn.Num2] = false;
                        p2Character.numD--;
                    }
                    else
                    {
                        PUT = false;
                        return;
                    }
                }
                UsualBtn2.Enabled = false;
                LRBtn2.Enabled = false;
                UDBtn2.Enabled = false;
                CovBtn2.Enabled = false;
                UsualBtn1.Enabled = true;
                LRBtn1.Enabled = true;
                UDBtn1.Enabled = true;
                CovBtn1.Enabled = true;
            }
            PUT = true;
            decide = "A";

        }

        int Mark = 0;   //計算附近連線的棋子有幾顆
        void vert(int i, int j, Chess[,] chess, bool[,] mark)
        {
            if (i< 0 || i >= 19)
                return;
            else if (mark[i, j] == true && count[i, j] == false)
            {
                Mark++;
                count[i, j] = true;
            }
            else return;
            vert(i - 1, j, chess, mark);
            vert(i + 1, j, chess, mark);

        }
        void horiz(int i, int j, Chess[,] chess, bool[,] mark)
        {
            if (j< 0 || j >=19)
                return;
            else if (mark[i, j] == true && count[i, j] == false)
            {
                Mark++;
                count[i, j] = true;
            }
            else return;
            horiz(i, j - 1, chess, mark);
            horiz(i, j + 1, chess, mark);

        }
        void LUtoRD(int i, int j, Chess[,] chess, bool[,] mark)
        {
            if (i < 0 || i >= 19 || j < 0 || j >= 19 )
                return;
            else if (mark[i,j]==true && count[i, j] == false)
            {
                Mark++;
                count[i, j] = true;
            }
            else return;
            LUtoRD(i - 1, j-1, chess, mark);
            LUtoRD(i + 1, j+1, chess, mark);

        }
        void LDtoRU(int i, int j, Chess[,] chess, bool[,] mark)
        {
            if (i < 0 || i >= 19 || j < 0 || j >= 19)
                return;
            else if (mark[i,j] && count[i, j] == false)
            {
                Mark++;
                count[i, j] = true;
            }
            else return;
            LDtoRU(i+1, j - 1, chess, mark);
            LDtoRU(i-1, j + 1, chess, mark);

        }

        bool win = false;
        void judge(int i,int j, Chess[,] chess,bool[,]mark)         //判斷四種方向有無連線，若無連線則重新計數並檢查下一種方向
        {
                vert(i, j, chess, mark);
                if (Mark >= 5) win = true;
                else
                {
                    Mark = 0;
                    for (int a=0; a < 19; a++)
                    {
                        for (int b = 0; b < 19; b++)
                            count[a, b] = false;
                    }
                }

                horiz(i, j, chess, mark);
                if (Mark >= 5) win = true;
                else
                {
                    Mark = 0;
                    for (int a = 0; a < 19; a++)
                    {
                        for (int b = 0; b < 19; b++)
                            count[a, b] = false;
                    }
                }

                LUtoRD(i, j, chess, mark);
                if (Mark >= 5) win = true;
                else
                {
                    Mark = 0;
                    for (int a = 0; a < 19; a++)
                    {
                        for (int b = 0; b < 19; b++)
                            count[a, b] = false;
                    }
                }

                LDtoRU(i, j, chess, mark);
                if (Mark >= 5) win = true;
                else
                {
                    Mark = 0;
                    for (int a = 0; a < 19; a++)
                    {
                        for (int b = 0; b < 19; b++)
                            count[a, b] = false;
                    }
                }

            
        }

        //選擇職業
        private void WarBtn1_Click(object sender, EventArgs e)
        {
            P1Job = "戰士";
            P1Label.Text = "P1:" + P1Job;
        }

        private void WitBtn1_Click(object sender, EventArgs e)
        {
            P1Job = "法師";
            P1Label.Text = "P1:" + P1Job;
        }

        private void ArcBtn1_Click(object sender, EventArgs e)
        {
            P1Job = "弓箭手";
            P1Label.Text = "P1:" + P1Job;
        }
        private void WarBtn2_Click(object sender, EventArgs e)
        {
            P2Job = "戰士";
            P2Label.Text = "P2:" + P2Job;
        }

        private void WitBtn2_Click(object sender, EventArgs e)
        {
            P2Job = "法師";
            P2Label.Text = "P2:" + P2Job;
        }
        private void ArcBtn2_Click(object sender, EventArgs e)
        {
            P2Job = "弓箭手";
            P2Label.Text = "P2:" + P2Job;
        }

        //選擇棋子
        private void UsualBtn1_Click(object sender, EventArgs e)
        {
            decide = "A";
        }
        private void LRBtn1_Click(object sender, EventArgs e)
        {
            decide = "B";
        }
        private void UDBtn1_Click(object sender, EventArgs e)
        {
            decide = "C";
        }
        private void CovBtn1_Click(object sender, EventArgs e)
        {
            decide = "D";
        }










    }
}
