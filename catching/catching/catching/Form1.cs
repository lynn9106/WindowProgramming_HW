using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Score;          //記錄分數
        int Time;           //倒數計時
        int prop;        //記錄屬性
        string Prop;
        bool ShootEnable=true;
        enemy Enemy1 = new enemy();
        enemy Enemy2 = new enemy();
        enemy Enemy3 = new enemy();
        enemy Enemy4 = new enemy();
        bullet Bullet = new bullet();
        Random rand = new Random();
        Button[] Bulletbtn = new Button[4];
        int[] PropNowBtn = new int[4];

        private void Form1_Load(object sender, EventArgs e)
        {
            STimer.Enabled = false;     //計算速度(0.1s)
            STimer.Interval = 100;
            CDownTimer.Enabled = false;     //倒數計時(1s)
            CDownTimer.Interval = 1000;
            BTimer.Enabled = false;         //子彈冷卻(1s)
            BTimer.Interval = 1000;
            Time = 60;
            Score = prop= 0;
            Enemy1.Property = Enemy2.Property = Enemy3.Property = Enemy4.Property = 0;
            enemy1.Size = enemy2.Size = enemy3.Size = enemy4.Size =Player.Size = new Size(Enemy1.ItemSize, Enemy1.ItemSize);
            enemy1.Location = new Point(20, 0);
            enemy2.Location = new Point(70, 0);
            enemy3.Location = new Point(120, 0);
            enemy4.Location = new Point(170, 0);
            Player.Location = new Point(70, 300);

            for(int i=0;i<4;i++)
            {
                Bulletbtn[i] = new Button();
                Bulletbtn[i].Visible = false;
                Bulletbtn[i].Size = new Size(Bullet.ItemSize, Bullet.ItemSize);
                this.Controls.Add(Bulletbtn[i]);
            }


        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            CDownTimer.Enabled = true;
            STimer.Enabled = true;

            SelectLabel.Visible = false;
            panel1.Visible = false;
            EnterBtn.Visible = false;

            Player.Visible = true;
            propLabel.Visible = true;
            ScoreLabel.Visible = true;
            TimeLabel.Visible = true;

            if(Water.Checked==true)         //玩家起始屬性
            {
                prop = 0;
                appearance(Player, prop);
            }
            else if(Fire.Checked==true)
            {
                prop = 1;
                appearance(Player, prop);
            }
            else if(Wood.Checked==true)
            {
                prop = 2;
                appearance(Player, prop);
            }

            switch (prop)
            {
                case 0:
                    Prop = "水";
                    break;
                case 1:
                    Prop = "火";
                    break;
                case 2:
                    Prop = "木";
                    break;
            }

            propLabel.Text = "目前屬性:"+Prop;
            ScoreLabel.Text = "目前分數:" + Score;
            TimeLabel.Text = "剩餘時間:" + Time;
        }

        private void CDowntimer_Tick(object sender, EventArgs e)        //倒數計時，結束時跳出messagebox
        {
            TimeLabel.Text = "剩餘時間:" + Time;
            if (Time == 0)
            {
                CDownTimer.Enabled = false;
                STimer.Enabled = false;
                DialogResult result;
                result=MessageBox.Show("遊戲結束!\n你的分數:" + Score, "", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
                return;
            }
            Time--;
        }

        private void STimer_Tick(object sender, EventArgs e)        //{掉落過程}  設定每100ms掉落距離(速度)
        {
            Meet(Player, enemy1, Enemy1);
            Meet(Player, enemy2, Enemy2);
            Meet(Player, enemy3, Enemy3);
            Meet(Player, enemy4, Enemy4);
            Fall(enemy1, Enemy1);
            Fall(enemy2, Enemy2);
            Fall(enemy3, Enemy3);
            Fall(enemy4, Enemy4);

            for(int i=0;i<4;i++)
            {
                Shoot(Bulletbtn[i], Bullet, PropNowBtn[i]);
                Hit(Bulletbtn[i], enemy1, Enemy1, Bullet, PropNowBtn[i]);
                Hit(Bulletbtn[i], enemy2, Enemy2, Bullet, PropNowBtn[i]);
                Hit(Bulletbtn[i], enemy3, Enemy3, Bullet, PropNowBtn[i]);
                Hit(Bulletbtn[i], enemy4, Enemy4, Bullet, PropNowBtn[i]);
            }

            if (Score < 0)
            {
                CDownTimer.Enabled = false;
                STimer.Enabled = false;
                Score = 0;
                DialogResult result;
                if (prop==0)
                result= MessageBox.Show("你枯竭了!\n你的分數:" + Score, "", MessageBoxButtons.OK);
                else if(prop==1)
                result = MessageBox.Show("你被熄滅了!\n你的分數:" + Score, "", MessageBoxButtons.OK);
                else
                result = MessageBox.Show("你燒起來了!\n你的分數:" + Score, "", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
                return;
            }


            propLabel.Text = "目前屬性:" + Prop;
            ScoreLabel.Text = "目前分數:" + Score;
        }

        void appearance(Button b,int prop)          //根據屬性設定物件外觀
        {
            switch(prop)
            {
                case 0:
                    b.BackColor = Color.Blue;
                    b.Text = "水";
                    break;
                case 1:
                    b.BackColor = Color.Red;
                    b.Text = "火";
                    break;
                case 2:
                    b.BackColor = Color.Green;
                    b.Text = "木";
                    break;
            }
            if (b == Player)
                b.Text = "你";
            else if (b == Bulletbtn[0]|| b == Bulletbtn[1] || b == Bulletbtn[2] || b == Bulletbtn[3])  //
                b.Text = "";

          return;
        }

        void Fall(Button b,enemy e)         //掉落至底消失，並重新隨機顯示屬性再次從最上方掉落
        {
            b.Top += e.Speed(e.Property);
            if (b.Top >= 400)
                b.Visible = false;
            if (b.Visible == false)
            {
                e.Property = rand.Next(3);
                appearance(b, e.Property);
                b.Top = 0;
                b.Visible = true;
            }
        }

        void Shoot(Button b, bullet Bullet, int PropNow)         //掉落至底消失，並重新隨機顯示屬性再次從最上方掉落
        {
            if (b.Visible == true)
            {
                b.Top -= Bullet.Speed(PropNow);
                if (b.Top <= 0)
                {
                    b.Visible = false;
                    b.Location = new Point(Player.Left + 10, Player.Top);//設子彈的位置為目前玩家位置的中央
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)          // 根據e.KeyCode分別執行
            {
                case Keys.A:
                    if (Player.Left > enemy1.Left)
                        Player.Left-= 50;
                    break;
                case Keys.D:
                    if (Player.Left < enemy4.Left)
                        Player.Left += 50;
                    break;
                case Keys.W:         // 若按空白鍵
                        if (ShootEnable==true) 
                        {
                            BTimer.Enabled = true;                   
                        }                    
                    break;

            }
        }

        private void BTimer_Tick(object sender, EventArgs e)        //一秒冷卻時間
        {
            for (int i = 0; i < 4; i++)
            {
                if (Bulletbtn[i].Visible == false && ShootEnable == true)
                {
                    ShootEnable = false;
                    Bullet.Property = PropNowBtn[i]=prop;
                    appearance(Bulletbtn[i], prop);
                    Bulletbtn[i].Location = new Point(Player.Left + 10, Player.Top);//設子彈的位置為目前玩家位置的中央
                    Bulletbtn[i].Visible = true;//子彈設為可見  
                }
            }
            ShootEnable = true;
            BTimer.Enabled = false;
        }


        void Hit(Button Bullet, Button enemy, enemy e,bullet b,int PropNow)             //子彈射到敵人時
        {
            if (Bullet.Top < enemy.Top && Bullet.Left==enemy.Left+10)
            {
                Bullet.Visible = false;
                enemy.Visible = false;
                Bullet.Location = new Point(Player.Left + 10, Player.Top);//設子彈的位置為目前玩家位置的中央
                if ((PropNow == e.Property - 1) || (PropNow == 2 && e.Property == 0))     //敵人被子彈克制
                    Score += 2;
                else if ((PropNow == e.Property + 1) || (PropNow == 0 && e.Property == 2))       //子彈遇到被克制屬性的敵人
                    Score -= 2;
            }
            return;
        }

        void Meet(Button player,Button enemy,enemy e)           //玩家與敵人相遇
        {
            if (player.Location==enemy.Location)
            {
                if((prop==e.Property-1)||(prop==2&&e.Property==0))        //玩家遇到克制屬性的敵人(水碰到火)
                {
                    Score += 5;
                    enemy.Visible = false;
                    prop = e.Property;
                }
                else if((prop==e.Property+1)||(prop==0&&e.Property==2))         //玩家遇到被克制屬性的敵人(水碰到木)
                {
                    Score -= 5;
                    enemy.Visible = false;
                }
            }
            appearance(Player, prop);
            switch(prop)
            {
                case 0:
                    Prop = "水";
                    break;
                case 1:
                    Prop = "火";
                    break;
                case 2:
                    Prop = "木";
                    break;

            }
            return;
        }


    }
}
