using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSdisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try {
                Number.Enabled = true;
                this.panel1.Controls.Clear();
                this.panel2.Controls.Clear();
                int y = int.Parse(Height.Text);
                int x = int.Parse(Width.Text);

                if (y > 15 || y < 7 || x < 5 || x > 10)         //檢查高與寬的範圍
                {
                    MessageBox.Show("請輸入範圍內的數字！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Number.Enabled = false;
                    return;
                }
                if (y % 2 == 0)         //檢查高是否為奇數
                {
                    MessageBox.Show("高不能為偶數！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Number.Enabled = false;
                    return;
                }


                Button[,] b1 = btnArray(panel1, 170);               //建立兩個顯示器
                Button[,] b2 = btnArray(panel2, 400);

                if (Number.Text != "")                  //若更改高與寬，仍顯示輸入的數字
                {
                    int num = int.Parse(Number.Text);
                   this.panel1.Controls.Clear();
                   this.panel2.Controls.Clear();
                    Judge(num);
                }
            }
            catch(FormatException)              //檢查輸入之格式
            {
                MessageBox.Show("請輸入數字！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Number.Enabled = false;
                return;
            }
        }       

        private void Number_TextChanged(object sender, EventArgs e)
            {
                try
                {
                int num = int.Parse(Number.Text);
                if (num >= -9 && num <= 99)             //若數字介於-9~99，顯示數字，否則顯示空白
                {
                    this.panel1.Controls.Clear();
                    this.panel2.Controls.Clear();
                    Judge(num);
                }
                else
                {
                    this.panel1.Controls.Clear();
                    this.panel2.Controls.Clear();
                    Button[,] b1 = btnArray(panel1, 170);               
                    Button[,] b2 = btnArray(panel2, 400);
                    return;
                }
                }
            catch(FormatException)
            {
                this.panel1.Controls.Clear();
                this.panel2.Controls.Clear();
                Button[,] b1 = btnArray(panel1, 170);
                Button[,] b2 = btnArray(panel2, 400);
                return;
            }

            }
        

        
        protected Button[,] btnArray(Panel panel,int Xlocation)                 //在Panel中建立ButtonArray(顯示器)
        {
            panel.Width = 200;
            panel.Height = 280;
            panel.Location = new Point(Xlocation, 30);
            int y = int.Parse(Height.Text);
            int x = int.Parse(Width.Text);
            int w = panel.Width / x;
            int h = panel.Height / y;
            Button[,] b = new Button[x, y];

            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    b[i, j] = new Button();
                    b[i, j].SetBounds(w * i, h * j, w * 9 / 10, h * 9 / 10);//(starting point X, starting point Y, width, heighth)
                    b[i, j].BackColor =Color.White;
                    panel.Controls.Add(b[i, j]);
                }
            }
            return b;
        }


        protected void Change(Panel panel, Button[,] b,int a)               //顯示器上數字顯示方式
        {
            int y = int.Parse(Height.Text);
            int x = int.Parse(Width.Text);
            int w = panel.Width / x;
            int h = panel.Height / y;
                    switch (a)
                    {
                        case 0:
                            for (int i = 1; i < x - 1; i++)
                            {
                                b[i, 0].BackColor = Color.Blue;
                                b[i, y - 1].BackColor = Color.Blue;
                            }
                            for (int j = 1; j < y - 1; j++)
                            {
                                b[0, j].BackColor = Color.Blue;
                                b[x - 1, j].BackColor = Color.Blue;
                            }
                            break;
                        case 1:
                            for (int j = 1; j < y - 1; j++)
                                b[x - 1, j].BackColor = Color.Blue;
                            break;
                        case 2:
                            for (int i = 1; i < x - 1; i++)
                            {
                                b[i, 0].BackColor = Color.Blue;
                                b[i, y - 1].BackColor = Color.Blue;
                                b[i, (y - 1) / 2].BackColor = Color.Blue;
                            }
                            for (int j = 1; j < (y - 1)/2; j++)
                                b[x - 1, j].BackColor = Color.Blue;
                            for (int j =(y-1)/2; j < y; j++)
                                b[0, j].BackColor = Color.Blue;
                            break;
                        case 3:
                            for (int i = 1; i < x - 1; i++)
                            {
                                b[i, 0].BackColor = Color.Blue;
                                b[i, y - 1].BackColor = Color.Blue;
                                b[i, (y - 1) / 2].BackColor = Color.Blue;
                            }
                            for (int j = 1; j < y - 1; j++)
                                b[x - 1, j].BackColor = Color.Blue;
                            break;
                        case 4:
                            for (int j = 1; j < (y - 1) / 2; j++)
                                b[0, j].BackColor = Color.Blue;
                            for (int j = 1; j < y - 1; j++)
                                b[x - 1, j].BackColor = Color.Blue;
                            for (int i = 1; i < x - 1; i++)
                                b[i, (y - 1) / 2].BackColor = Color.Blue;                           
                            break;
                        case 5:
                            for (int i = 1; i < x - 1; i++)
                            {
                                b[i, 0].BackColor = Color.Blue;
                                b[i, y - 1].BackColor = Color.Blue;
                                b[i, (y - 1) / 2].BackColor = Color.Blue;
                            }
                            for (int j = 1; j < (y - 1) / 2; j++)
                                b[0, j].BackColor = Color.Blue;
                            for (int j = (y - 1) / 2; j < y; j++)
                                b[x-1, j].BackColor = Color.Blue;
                            break;
                        case 6:
                            for (int i = 1; i < x - 1; i++)
                            {
                                b[i, 0].BackColor = Color.Blue;
                                b[i, y - 1].BackColor = Color.Blue;
                                b[i, (y - 1) / 2].BackColor = Color.Blue;
                            }
                            for (int j = 1; j < y - 1; j++)
                                b[0, j].BackColor = Color.Blue;
                            for (int j = (y - 1) / 2; j < y; j++)
                                b[x - 1, j].BackColor = Color.Blue;
                            break;
                        case 7:
                            for (int i = 1; i < x - 1; i++)
                                b[i, 0].BackColor = Color.Blue;
                            for (int j = 1; j < y - 1; j++)
                                b[x - 1, j].BackColor = Color.Blue;
                            break;
                        case 8:
                            for (int i = 1; i < x - 1; i++)
                            {
                                b[i, 0].BackColor = Color.Blue;
                                b[i, y - 1].BackColor = Color.Blue;
                                b[i, (y - 1)/2].BackColor = Color.Blue;
                            }
                            for (int j = 1; j < y - 1; j++)
                            {
                                b[0, j].BackColor = Color.Blue;
                                b[x - 1, j].BackColor = Color.Blue;
                            }
                            break;
                        case 9:
                            for (int i = 1; i < x - 1; i++)
                            {
                                b[i, 0].BackColor = Color.Blue;
                                b[i, y - 1].BackColor = Color.Blue;
                                b[i, (y - 1) / 2].BackColor = Color.Blue;
                            }
                            for (int j = 1; j < y - 1; j++)
                                b[x - 1, j].BackColor = Color.Blue;
                            for (int j = 1; j < (y - 1) / 2; j++)
                                b[0, j].BackColor = Color.Blue;
                            break;
                    }
            if (a < 0)
            {
                for (int i = 1; i < x - 1; i++)
                    b[i, (y - 1) / 2].BackColor = Color.Blue;
            }
            b[0, (y - 1) / 2].BackColor = Color.White;
            b[x - 1, (y - 1) / 2].BackColor = Color.White;
                
            
        }

        protected void Judge(int num)                           //判斷輸入之數字，使兩個顯示器分別顯示數字
        {
            
            Button[,] b1 = btnArray(panel1, 170);
            Button[,] b2 = btnArray(panel2, 400);
            if (num >= 0 && num <= 9)
            {
                Change(panel1, b1, 0);
                Change(panel2, b2, num);
            }
            else if(num>9&&num<20)
            {
                Change(panel1, b1, 1);
                Change(panel2,b2, num % 10);
            }
            else if(num>19&&num<30)
            {
                Change(panel1, b1, 2);
                Change(panel2, b2, num % 20);
            }
            else if (num > 29 && num < 40)
            {
                Change(panel1, b1, 3);
                Change(panel2, b2, num % 30);
            }
            else if (num > 39 && num < 50)
            {
                Change(panel1, b1, 4);
                Change(panel2, b2, num % 40);
            }
            else if (num > 49 && num < 60)
            {
                Change(panel1, b1, 5);
                Change(panel2, b2, num % 50);
            }
            else if (num > 59 && num < 70)
            {
                Change(panel1, b1, 6);
                Change(panel2, b2, num % 60);
            }
            else if (num > 69 && num < 80)
            {
                Change(panel1, b1, 7);
                Change(panel2, b2, num % 70);
            }
            else if (num > 79 && num < 90)
            {
                Change(panel1, b1, 8);
                Change(panel2, b2, num % 80);
            }
            else if (num > 89 && num < 100)
            {
                Change(panel1, b1, 9);
                Change(panel2, b2, num % 90);
            }
            else if(num>=-9&&num<0)
            {
                Change(panel1, b1,num);
                Change(panel2, b2, -num);
            }
        }



      

    }
}
