namespace SSdisplay
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
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.EnterLabel = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(37, 53);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(31, 21);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "高";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(37, 109);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(31, 21);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "寬";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(74, 50);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(116, 33);
            this.Height.TabIndex = 2;
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(74, 106);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(116, 33);
            this.Width.TabIndex = 3;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(74, 170);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(113, 54);
            this.Ok.TabIndex = 4;
            this.Ok.Text = "確認";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // EnterLabel
            // 
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.Location = new System.Drawing.Point(37, 525);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(156, 21);
            this.EnterLabel.TabIndex = 5;
            this.EnterLabel.Text = "請輸數字(-9~99)";
            // 
            // Number
            // 
            this.Number.Enabled = false;
            this.Number.Location = new System.Drawing.Point(41, 558);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(149, 33);
            this.Number.TabIndex = 6;
            this.Number.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(261, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 473);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(718, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 473);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.EnterLabel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label EnterLabel;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

