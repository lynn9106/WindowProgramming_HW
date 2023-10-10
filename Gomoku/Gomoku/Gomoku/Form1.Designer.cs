namespace Gomoku
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
            this.P2Label = new System.Windows.Forms.Label();
            this.P1Label = new System.Windows.Forms.Label();
            this.WarBtn2 = new System.Windows.Forms.Button();
            this.WitBtn2 = new System.Windows.Forms.Button();
            this.ArcBtn2 = new System.Windows.Forms.Button();
            this.WarBtn1 = new System.Windows.Forms.Button();
            this.WitBtn1 = new System.Windows.Forms.Button();
            this.ArcBtn1 = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.UsualBtn2 = new System.Windows.Forms.Button();
            this.LRBtn2 = new System.Windows.Forms.Button();
            this.UDBtn2 = new System.Windows.Forms.Button();
            this.CovBtn2 = new System.Windows.Forms.Button();
            this.CovBtn1 = new System.Windows.Forms.Button();
            this.UDBtn1 = new System.Windows.Forms.Button();
            this.LRBtn1 = new System.Windows.Forms.Button();
            this.UsualBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // P2Label
            // 
            this.P2Label.AutoSize = true;
            this.P2Label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2Label.Location = new System.Drawing.Point(77, 72);
            this.P2Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.P2Label.Name = "P2Label";
            this.P2Label.Size = new System.Drawing.Size(135, 43);
            this.P2Label.TabIndex = 0;
            this.P2Label.Text = "P2:戰士";
            // 
            // P1Label
            // 
            this.P1Label.AutoSize = true;
            this.P1Label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1Label.Location = new System.Drawing.Point(1373, 72);
            this.P1Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.P1Label.Name = "P1Label";
            this.P1Label.Size = new System.Drawing.Size(135, 43);
            this.P1Label.TabIndex = 1;
            this.P1Label.Text = "P1:戰士";
            // 
            // WarBtn2
            // 
            this.WarBtn2.Location = new System.Drawing.Point(81, 177);
            this.WarBtn2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WarBtn2.Name = "WarBtn2";
            this.WarBtn2.Size = new System.Drawing.Size(136, 72);
            this.WarBtn2.TabIndex = 2;
            this.WarBtn2.Text = "戰士";
            this.WarBtn2.UseVisualStyleBackColor = true;
            this.WarBtn2.Click += new System.EventHandler(this.WarBtn2_Click);
            // 
            // WitBtn2
            // 
            this.WitBtn2.Location = new System.Drawing.Point(81, 284);
            this.WitBtn2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WitBtn2.Name = "WitBtn2";
            this.WitBtn2.Size = new System.Drawing.Size(136, 72);
            this.WitBtn2.TabIndex = 3;
            this.WitBtn2.Text = "法師";
            this.WitBtn2.UseVisualStyleBackColor = true;
            this.WitBtn2.Click += new System.EventHandler(this.WitBtn2_Click);
            // 
            // ArcBtn2
            // 
            this.ArcBtn2.Location = new System.Drawing.Point(81, 390);
            this.ArcBtn2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ArcBtn2.Name = "ArcBtn2";
            this.ArcBtn2.Size = new System.Drawing.Size(136, 72);
            this.ArcBtn2.TabIndex = 4;
            this.ArcBtn2.Text = "弓箭手";
            this.ArcBtn2.UseVisualStyleBackColor = true;
            this.ArcBtn2.Click += new System.EventHandler(this.ArcBtn2_Click);
            // 
            // WarBtn1
            // 
            this.WarBtn1.Location = new System.Drawing.Point(1373, 177);
            this.WarBtn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WarBtn1.Name = "WarBtn1";
            this.WarBtn1.Size = new System.Drawing.Size(136, 72);
            this.WarBtn1.TabIndex = 5;
            this.WarBtn1.Text = "戰士";
            this.WarBtn1.UseVisualStyleBackColor = true;
            this.WarBtn1.Click += new System.EventHandler(this.WarBtn1_Click);
            // 
            // WitBtn1
            // 
            this.WitBtn1.Location = new System.Drawing.Point(1373, 284);
            this.WitBtn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WitBtn1.Name = "WitBtn1";
            this.WitBtn1.Size = new System.Drawing.Size(136, 72);
            this.WitBtn1.TabIndex = 6;
            this.WitBtn1.Text = "法師";
            this.WitBtn1.UseVisualStyleBackColor = true;
            this.WitBtn1.Click += new System.EventHandler(this.WitBtn1_Click);
            // 
            // ArcBtn1
            // 
            this.ArcBtn1.Location = new System.Drawing.Point(1373, 390);
            this.ArcBtn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ArcBtn1.Name = "ArcBtn1";
            this.ArcBtn1.Size = new System.Drawing.Size(136, 72);
            this.ArcBtn1.TabIndex = 7;
            this.ArcBtn1.Text = "弓箭手";
            this.ArcBtn1.UseVisualStyleBackColor = true;
            this.ArcBtn1.Click += new System.EventHandler(this.ArcBtn1_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(647, 534);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(220, 105);
            this.StartBtn.TabIndex = 8;
            this.StartBtn.Text = "開始遊戲";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // UsualBtn2
            // 
            this.UsualBtn2.Location = new System.Drawing.Point(55, 156);
            this.UsualBtn2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UsualBtn2.Name = "UsualBtn2";
            this.UsualBtn2.Size = new System.Drawing.Size(216, 72);
            this.UsualBtn2.TabIndex = 9;
            this.UsualBtn2.Text = "普通棋子";
            this.UsualBtn2.UseVisualStyleBackColor = true;
            this.UsualBtn2.Visible = false;
            this.UsualBtn2.Click += new System.EventHandler(this.UsualBtn1_Click);
            // 
            // LRBtn2
            // 
            this.LRBtn2.Location = new System.Drawing.Point(55, 238);
            this.LRBtn2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LRBtn2.Name = "LRBtn2";
            this.LRBtn2.Size = new System.Drawing.Size(216, 72);
            this.LRBtn2.TabIndex = 10;
            this.LRBtn2.Text = "橫向棋子";
            this.LRBtn2.UseVisualStyleBackColor = true;
            this.LRBtn2.Visible = false;
            this.LRBtn2.Click += new System.EventHandler(this.LRBtn1_Click);
            // 
            // UDBtn2
            // 
            this.UDBtn2.Location = new System.Drawing.Point(55, 320);
            this.UDBtn2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UDBtn2.Name = "UDBtn2";
            this.UDBtn2.Size = new System.Drawing.Size(216, 72);
            this.UDBtn2.TabIndex = 11;
            this.UDBtn2.Text = "縱向棋子";
            this.UDBtn2.UseVisualStyleBackColor = true;
            this.UDBtn2.Visible = false;
            this.UDBtn2.Click += new System.EventHandler(this.UDBtn1_Click);
            // 
            // CovBtn2
            // 
            this.CovBtn2.Location = new System.Drawing.Point(55, 402);
            this.CovBtn2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CovBtn2.Name = "CovBtn2";
            this.CovBtn2.Size = new System.Drawing.Size(216, 72);
            this.CovBtn2.TabIndex = 12;
            this.CovBtn2.Text = "覆蓋棋子";
            this.CovBtn2.UseVisualStyleBackColor = true;
            this.CovBtn2.Visible = false;
            this.CovBtn2.Click += new System.EventHandler(this.CovBtn1_Click);
            // 
            // CovBtn1
            // 
            this.CovBtn1.Location = new System.Drawing.Point(1340, 402);
            this.CovBtn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CovBtn1.Name = "CovBtn1";
            this.CovBtn1.Size = new System.Drawing.Size(216, 72);
            this.CovBtn1.TabIndex = 16;
            this.CovBtn1.Text = "覆蓋棋子";
            this.CovBtn1.UseVisualStyleBackColor = true;
            this.CovBtn1.Visible = false;
            this.CovBtn1.Click += new System.EventHandler(this.CovBtn1_Click);
            // 
            // UDBtn1
            // 
            this.UDBtn1.Location = new System.Drawing.Point(1340, 320);
            this.UDBtn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UDBtn1.Name = "UDBtn1";
            this.UDBtn1.Size = new System.Drawing.Size(216, 72);
            this.UDBtn1.TabIndex = 15;
            this.UDBtn1.Text = "縱向棋子";
            this.UDBtn1.UseVisualStyleBackColor = true;
            this.UDBtn1.Visible = false;
            this.UDBtn1.Click += new System.EventHandler(this.UDBtn1_Click);
            // 
            // LRBtn1
            // 
            this.LRBtn1.Location = new System.Drawing.Point(1340, 238);
            this.LRBtn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LRBtn1.Name = "LRBtn1";
            this.LRBtn1.Size = new System.Drawing.Size(216, 72);
            this.LRBtn1.TabIndex = 14;
            this.LRBtn1.Text = "橫向棋子";
            this.LRBtn1.UseVisualStyleBackColor = true;
            this.LRBtn1.Visible = false;
            this.LRBtn1.Click += new System.EventHandler(this.LRBtn1_Click);
            // 
            // UsualBtn1
            // 
            this.UsualBtn1.Location = new System.Drawing.Point(1340, 156);
            this.UsualBtn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UsualBtn1.Name = "UsualBtn1";
            this.UsualBtn1.Size = new System.Drawing.Size(216, 72);
            this.UsualBtn1.TabIndex = 13;
            this.UsualBtn1.Text = "普通棋子";
            this.UsualBtn1.UseVisualStyleBackColor = true;
            this.UsualBtn1.Visible = false;
            this.UsualBtn1.Click += new System.EventHandler(this.UsualBtn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1404);
            this.Controls.Add(this.CovBtn1);
            this.Controls.Add(this.UDBtn1);
            this.Controls.Add(this.LRBtn1);
            this.Controls.Add(this.UsualBtn1);
            this.Controls.Add(this.CovBtn2);
            this.Controls.Add(this.UDBtn2);
            this.Controls.Add(this.LRBtn2);
            this.Controls.Add(this.UsualBtn2);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.ArcBtn1);
            this.Controls.Add(this.WitBtn1);
            this.Controls.Add(this.WarBtn1);
            this.Controls.Add(this.ArcBtn2);
            this.Controls.Add(this.WitBtn2);
            this.Controls.Add(this.WarBtn2);
            this.Controls.Add(this.P1Label);
            this.Controls.Add(this.P2Label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P2Label;
        private System.Windows.Forms.Label P1Label;
        private System.Windows.Forms.Button WarBtn2;
        private System.Windows.Forms.Button WitBtn2;
        private System.Windows.Forms.Button ArcBtn2;
        private System.Windows.Forms.Button WarBtn1;
        private System.Windows.Forms.Button WitBtn1;
        private System.Windows.Forms.Button ArcBtn1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button UsualBtn2;
        private System.Windows.Forms.Button LRBtn2;
        private System.Windows.Forms.Button UDBtn2;
        private System.Windows.Forms.Button CovBtn2;
        private System.Windows.Forms.Button CovBtn1;
        private System.Windows.Forms.Button UDBtn1;
        private System.Windows.Forms.Button LRBtn1;
        private System.Windows.Forms.Button UsualBtn1;
    }
}

