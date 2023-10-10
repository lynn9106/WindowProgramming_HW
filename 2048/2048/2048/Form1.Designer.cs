namespace _2048
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
            this.easybtn = new System.Windows.Forms.Button();
            this.normbtn = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.NumLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // easybtn
            // 
            this.easybtn.Location = new System.Drawing.Point(390, 200);
            this.easybtn.Name = "easybtn";
            this.easybtn.Size = new System.Drawing.Size(120, 60);
            this.easybtn.TabIndex = 0;
            this.easybtn.TabStop = false;
            this.easybtn.Text = "簡單模式";
            this.easybtn.UseVisualStyleBackColor = true;
            this.easybtn.Click += new System.EventHandler(this.easybtn_Click);
            // 
            // normbtn
            // 
            this.normbtn.Location = new System.Drawing.Point(390, 350);
            this.normbtn.Name = "normbtn";
            this.normbtn.Size = new System.Drawing.Size(120, 60);
            this.normbtn.TabIndex = 1;
            this.normbtn.TabStop = false;
            this.normbtn.Text = "普通模式";
            this.normbtn.UseVisualStyleBackColor = true;
            this.normbtn.Click += new System.EventHandler(this.normbtn_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(669, 51);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(94, 21);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "你的分數";
            this.ScoreLabel.Visible = false;
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(669, 107);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(94, 21);
            this.NumLabel.TabIndex = 3;
            this.NumLabel.Text = "當前數字";
            this.NumLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 350);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(669, 165);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(94, 21);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "倒數計時";
            this.timeLabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 636);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.easybtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.normbtn);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easybtn;
        private System.Windows.Forms.Button normbtn;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

