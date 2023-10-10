namespace CardGame
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.roundLabel = new System.Windows.Forms.Label();
            this.P2Label = new System.Windows.Forms.Label();
            this.P1Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(408, 261);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(147, 66);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "開始遊戲";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("微軟正黑體", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roundLabel.Location = new System.Drawing.Point(350, 65);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(272, 43);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "第一回合 輪到P1";
            this.roundLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roundLabel.Visible = false;
            // 
            // P2Label
            // 
            this.P2Label.AutoSize = true;
            this.P2Label.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2Label.Location = new System.Drawing.Point(12, 177);
            this.P2Label.Name = "P2Label";
            this.P2Label.Size = new System.Drawing.Size(117, 34);
            this.P2Label.TabIndex = 3;
            this.P2Label.Text = "ScoreP2";
            this.P2Label.Visible = false;
            // 
            // P1Label
            // 
            this.P1Label.AutoSize = true;
            this.P1Label.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1Label.Location = new System.Drawing.Point(785, 177);
            this.P1Label.Name = "P1Label";
            this.P1Label.Size = new System.Drawing.Size(117, 34);
            this.P1Label.TabIndex = 4;
            this.P1Label.Text = "ScoreP1";
            this.P1Label.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 736);
            this.Controls.Add(this.P1Label);
            this.Controls.Add(this.P2Label);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label P2Label;
        private System.Windows.Forms.Label P1Label;
        private System.Windows.Forms.Timer timer1;
    }
}

