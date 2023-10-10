namespace meme
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
            this.backbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.FontS1 = new System.Windows.Forms.RadioButton();
            this.FontS2 = new System.Windows.Forms.RadioButton();
            this.FontS3 = new System.Windows.Forms.RadioButton();
            this.FontStyle = new System.Windows.Forms.GroupBox();
            this.Bold = new System.Windows.Forms.CheckBox();
            this.Italic = new System.Windows.Forms.CheckBox();
            this.position1 = new System.Windows.Forms.RadioButton();
            this.position2 = new System.Windows.Forms.RadioButton();
            this.position3 = new System.Windows.Forms.RadioButton();
            this.position4 = new System.Windows.Forms.RadioButton();
            this.position5 = new System.Windows.Forms.RadioButton();
            this.position6 = new System.Windows.Forms.RadioButton();
            this.position = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FontSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.FontStyle.SuspendLayout();
            this.position.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(70, 558);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(94, 46);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "前一張";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(590, 558);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(94, 46);
            this.nextbtn.TabIndex = 3;
            this.nextbtn.Text = "下一張";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // FontS1
            // 
            this.FontS1.AutoSize = true;
            this.FontS1.Location = new System.Drawing.Point(51, 36);
            this.FontS1.Name = "FontS1";
            this.FontS1.Size = new System.Drawing.Size(98, 25);
            this.FontS1.TabIndex = 4;
            this.FontS1.TabStop = true;
            this.FontS1.Text = "標楷體";
            this.FontS1.UseVisualStyleBackColor = true;
            this.FontS1.CheckedChanged += new System.EventHandler(this.FontS1_CheckedChanged);
            // 
            // FontS2
            // 
            this.FontS2.AutoSize = true;
            this.FontS2.Location = new System.Drawing.Point(51, 81);
            this.FontS2.Name = "FontS2";
            this.FontS2.Size = new System.Drawing.Size(140, 25);
            this.FontS2.TabIndex = 5;
            this.FontS2.TabStop = true;
            this.FontS2.Text = "微軟正黑體";
            this.FontS2.UseVisualStyleBackColor = true;
            this.FontS2.CheckedChanged += new System.EventHandler(this.FontS2_CheckedChanged);
            // 
            // FontS3
            // 
            this.FontS3.AutoSize = true;
            this.FontS3.Location = new System.Drawing.Point(212, 36);
            this.FontS3.Name = "FontS3";
            this.FontS3.Size = new System.Drawing.Size(119, 25);
            this.FontS3.TabIndex = 6;
            this.FontS3.TabStop = true;
            this.FontS3.Text = "新細明體";
            this.FontS3.UseVisualStyleBackColor = true;
            this.FontS3.CheckedChanged += new System.EventHandler(this.FontS3_CheckedChanged);
            // 
            // FontStyle
            // 
            this.FontStyle.Controls.Add(this.FontS3);
            this.FontStyle.Controls.Add(this.FontS2);
            this.FontStyle.Controls.Add(this.FontS1);
            this.FontStyle.Location = new System.Drawing.Point(791, 53);
            this.FontStyle.Name = "FontStyle";
            this.FontStyle.Size = new System.Drawing.Size(403, 123);
            this.FontStyle.TabIndex = 7;
            this.FontStyle.TabStop = false;
            this.FontStyle.Text = "字體";
            // 
            // Bold
            // 
            this.Bold.AutoSize = true;
            this.Bold.Location = new System.Drawing.Point(842, 200);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(78, 25);
            this.Bold.TabIndex = 8;
            this.Bold.Text = "粗體";
            this.Bold.UseVisualStyleBackColor = true;
            this.Bold.CheckedChanged += new System.EventHandler(this.Bold_CheckedChanged);
            // 
            // Italic
            // 
            this.Italic.AutoSize = true;
            this.Italic.Location = new System.Drawing.Point(1003, 200);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(78, 25);
            this.Italic.TabIndex = 9;
            this.Italic.Text = "斜體";
            this.Italic.UseVisualStyleBackColor = true;
            this.Italic.CheckedChanged += new System.EventHandler(this.Italic_CheckedChanged);
            // 
            // position1
            // 
            this.position1.AutoSize = true;
            this.position1.Location = new System.Drawing.Point(27, 32);
            this.position1.Name = "position1";
            this.position1.Size = new System.Drawing.Size(77, 25);
            this.position1.TabIndex = 10;
            this.position1.TabStop = true;
            this.position1.Text = "上左";
            this.position1.UseVisualStyleBackColor = true;
            this.position1.CheckedChanged += new System.EventHandler(this.position1_CheckedChanged);
            // 
            // position2
            // 
            this.position2.AutoSize = true;
            this.position2.Location = new System.Drawing.Point(165, 32);
            this.position2.Name = "position2";
            this.position2.Size = new System.Drawing.Size(77, 25);
            this.position2.TabIndex = 11;
            this.position2.TabStop = true;
            this.position2.Text = "上中";
            this.position2.UseVisualStyleBackColor = true;
            this.position2.CheckedChanged += new System.EventHandler(this.position2_CheckedChanged);
            // 
            // position3
            // 
            this.position3.AutoSize = true;
            this.position3.Location = new System.Drawing.Point(310, 32);
            this.position3.Name = "position3";
            this.position3.Size = new System.Drawing.Size(77, 25);
            this.position3.TabIndex = 12;
            this.position3.TabStop = true;
            this.position3.Text = "上右";
            this.position3.UseVisualStyleBackColor = true;
            this.position3.CheckedChanged += new System.EventHandler(this.position3_CheckedChanged);
            // 
            // position4
            // 
            this.position4.AutoSize = true;
            this.position4.Location = new System.Drawing.Point(27, 69);
            this.position4.Name = "position4";
            this.position4.Size = new System.Drawing.Size(77, 25);
            this.position4.TabIndex = 13;
            this.position4.TabStop = true;
            this.position4.Text = "下左";
            this.position4.UseVisualStyleBackColor = true;
            this.position4.CheckedChanged += new System.EventHandler(this.position4_CheckedChanged);
            // 
            // position5
            // 
            this.position5.AutoSize = true;
            this.position5.Location = new System.Drawing.Point(165, 69);
            this.position5.Name = "position5";
            this.position5.Size = new System.Drawing.Size(77, 25);
            this.position5.TabIndex = 14;
            this.position5.TabStop = true;
            this.position5.Text = "下中";
            this.position5.UseVisualStyleBackColor = true;
            this.position5.CheckedChanged += new System.EventHandler(this.position5_CheckedChanged);
            // 
            // position6
            // 
            this.position6.AutoSize = true;
            this.position6.Location = new System.Drawing.Point(310, 69);
            this.position6.Name = "position6";
            this.position6.Size = new System.Drawing.Size(77, 25);
            this.position6.TabIndex = 15;
            this.position6.TabStop = true;
            this.position6.Text = "下右";
            this.position6.UseVisualStyleBackColor = true;
            this.position6.CheckedChanged += new System.EventHandler(this.position6_CheckedChanged);
            // 
            // position
            // 
            this.position.Controls.Add(this.position6);
            this.position.Controls.Add(this.position5);
            this.position.Controls.Add(this.position4);
            this.position.Controls.Add(this.position3);
            this.position.Controls.Add(this.position2);
            this.position.Controls.Add(this.position1);
            this.position.Location = new System.Drawing.Point(791, 239);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(403, 110);
            this.position.TabIndex = 16;
            this.position.TabStop = false;
            this.position.Text = "位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(831, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "字體大小:";
            // 
            // FontSize
            // 
            this.FontSize.Location = new System.Drawing.Point(936, 375);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(139, 33);
            this.FontSize.TabIndex = 18;
            this.FontSize.TextChanged += new System.EventHandler(this.FontSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(968, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "文字";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(791, 473);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(403, 119);
            this.textBox.TabIndex = 20;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("新細明體", 25F);
            this.label.Location = new System.Drawing.Point(60, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(624, 78);
            this.label.TabIndex = 0;
            this.label.Text = "文字";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(122, 128);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(500, 280);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 647);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.position);
            this.Controls.Add(this.Italic);
            this.Controls.Add(this.Bold);
            this.Controls.Add(this.FontStyle);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FontStyle.ResumeLayout(false);
            this.FontStyle.PerformLayout();
            this.position.ResumeLayout(false);
            this.position.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.RadioButton FontS1;
        private System.Windows.Forms.RadioButton FontS2;
        private System.Windows.Forms.RadioButton FontS3;
        private System.Windows.Forms.GroupBox FontStyle;
        private System.Windows.Forms.CheckBox Bold;
        private System.Windows.Forms.CheckBox Italic;
        private System.Windows.Forms.RadioButton position1;
        private System.Windows.Forms.RadioButton position2;
        private System.Windows.Forms.RadioButton position3;
        private System.Windows.Forms.RadioButton position4;
        private System.Windows.Forms.RadioButton position5;
        private System.Windows.Forms.RadioButton position6;
        private System.Windows.Forms.GroupBox position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FontSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pic;
    }
}

