namespace catching
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player = new System.Windows.Forms.Button();
            this.enemy4 = new System.Windows.Forms.Button();
            this.enemy3 = new System.Windows.Forms.Button();
            this.enemy2 = new System.Windows.Forms.Button();
            this.enemy1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Wood = new System.Windows.Forms.RadioButton();
            this.Fire = new System.Windows.Forms.RadioButton();
            this.Water = new System.Windows.Forms.RadioButton();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.propLabel = new System.Windows.Forms.Label();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.STimer = new System.Windows.Forms.Timer(this.components);
            this.CDownTimer = new System.Windows.Forms.Timer(this.components);
            this.BTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.ForeColor = System.Drawing.Color.White;
            this.Player.Location = new System.Drawing.Point(70, 300);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(40, 40);
            this.Player.TabIndex = 13;
            this.Player.Text = "player";
            this.Player.UseVisualStyleBackColor = true;
            this.Player.Visible = false;
            // 
            // enemy4
            // 
            this.enemy4.ForeColor = System.Drawing.Color.White;
            this.enemy4.Location = new System.Drawing.Point(170, 20);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(40, 40);
            this.enemy4.TabIndex = 12;
            this.enemy4.Text = "e4";
            this.enemy4.UseVisualStyleBackColor = true;
            this.enemy4.Visible = false;
            // 
            // enemy3
            // 
            this.enemy3.ForeColor = System.Drawing.Color.White;
            this.enemy3.Location = new System.Drawing.Point(120, 20);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(40, 40);
            this.enemy3.TabIndex = 11;
            this.enemy3.Text = "e3";
            this.enemy3.UseVisualStyleBackColor = true;
            this.enemy3.Visible = false;
            // 
            // enemy2
            // 
            this.enemy2.ForeColor = System.Drawing.Color.White;
            this.enemy2.Location = new System.Drawing.Point(70, 20);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(40, 40);
            this.enemy2.TabIndex = 10;
            this.enemy2.Text = "e2";
            this.enemy2.UseVisualStyleBackColor = true;
            this.enemy2.Visible = false;
            // 
            // enemy1
            // 
            this.enemy1.ForeColor = System.Drawing.Color.White;
            this.enemy1.Location = new System.Drawing.Point(20, 20);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(40, 40);
            this.enemy1.TabIndex = 9;
            this.enemy1.Text = "e1";
            this.enemy1.UseVisualStyleBackColor = true;
            this.enemy1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Wood);
            this.panel1.Controls.Add(this.Fire);
            this.panel1.Controls.Add(this.Water);
            this.panel1.Location = new System.Drawing.Point(257, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 126);
            this.panel1.TabIndex = 20;
            // 
            // Wood
            // 
            this.Wood.AutoSize = true;
            this.Wood.Location = new System.Drawing.Point(5, 90);
            this.Wood.Name = "Wood";
            this.Wood.Size = new System.Drawing.Size(56, 25);
            this.Wood.TabIndex = 2;
            this.Wood.TabStop = true;
            this.Wood.Text = "木";
            this.Wood.UseVisualStyleBackColor = true;
            // 
            // Fire
            // 
            this.Fire.AutoSize = true;
            this.Fire.Location = new System.Drawing.Point(5, 48);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(56, 25);
            this.Fire.TabIndex = 1;
            this.Fire.TabStop = true;
            this.Fire.Text = "火";
            this.Fire.UseVisualStyleBackColor = true;
            // 
            // Water
            // 
            this.Water.AutoSize = true;
            this.Water.Checked = true;
            this.Water.Location = new System.Drawing.Point(5, 3);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(56, 25);
            this.Water.TabIndex = 0;
            this.Water.TabStop = true;
            this.Water.Text = "水";
            this.Water.UseVisualStyleBackColor = true;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(508, 100);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(94, 21);
            this.TimeLabel.TabIndex = 19;
            this.TimeLabel.Text = "剩餘時間";
            this.TimeLabel.Visible = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(508, 63);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(94, 21);
            this.ScoreLabel.TabIndex = 18;
            this.ScoreLabel.Text = "目前分數";
            this.ScoreLabel.Visible = false;
            // 
            // propLabel
            // 
            this.propLabel.AutoSize = true;
            this.propLabel.Location = new System.Drawing.Point(508, 20);
            this.propLabel.Name = "propLabel";
            this.propLabel.Size = new System.Drawing.Size(94, 21);
            this.propLabel.TabIndex = 17;
            this.propLabel.Text = "目前屬性";
            this.propLabel.Visible = false;
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(258, 100);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(136, 21);
            this.SelectLabel.TabIndex = 16;
            this.SelectLabel.Text = "選擇初始屬性";
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(262, 285);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(139, 55);
            this.EnterBtn.TabIndex = 15;
            this.EnterBtn.Text = "開始";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // STimer
            // 
            this.STimer.Tick += new System.EventHandler(this.STimer_Tick);
            // 
            // CDownTimer
            // 
            this.CDownTimer.Interval = 1000;
            this.CDownTimer.Tick += new System.EventHandler(this.CDowntimer_Tick);
            // 
            // BTimer
            // 
            this.BTimer.Interval = 1000;
            this.BTimer.Tick += new System.EventHandler(this.BTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 636);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.propLabel);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.EnterBtn);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Player;
        private System.Windows.Forms.Button enemy4;
        private System.Windows.Forms.Button enemy3;
        private System.Windows.Forms.Button enemy2;
        private System.Windows.Forms.Button enemy1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Wood;
        private System.Windows.Forms.RadioButton Fire;
        private System.Windows.Forms.RadioButton Water;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label propLabel;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Timer STimer;
        private System.Windows.Forms.Timer CDownTimer;
        private System.Windows.Forms.Timer BTimer;
    }
}

