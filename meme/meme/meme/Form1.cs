using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int current;
        Class Word=new Class();
        bool bold = false;
        bool italic = false;
        
        private void FigShow()                  //顯示圖片
        {
         pic.Image = Image.FromFile(@"..\..\pic\pic" + current + ".png");
         label.Text="";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            current = 1;
            FigShow();
            label.Font =Word.f;
            label.TextAlign = Word.Alignment;
            label.Top = Word.y;
        }

        private void backbtn_Click(object sender, EventArgs e)              //前一張(第一跳回第五)
        {
            if (current == 1) current = 5;
            else current--;
            FigShow();
            label.Text = textBox.Text;
        }

        private void nextbtn_Click(object sender, EventArgs e)           //下一張(第五跳回第一)
        {
            if (current == 5) current = 1;
            else current++;
            FigShow();
            label.Text = textBox.Text;

        }

        private void textBox_TextChanged(object sender, EventArgs e)            //輸入文字改變label
        {
         label.Text = textBox.Text;        
        }

        private void FontS1_CheckedChanged(object sender, EventArgs e)          //選擇標楷體
        {
            Word.ChangeFamily("標楷體");
            label.Font = Word.f;
        }

        private void FontS2_CheckedChanged(object sender, EventArgs e)          //選擇微軟正黑體          
        {
            Word.ChangeFamily("微軟正黑體");
            label.Font = Word.f;
        }
        private void FontS3_CheckedChanged(object sender, EventArgs e)          //選擇新細明體
        {
            Word.ChangeFamily("新細明體");
            label.Font = Word.f;
        }

        private void Bold_CheckedChanged(object sender, EventArgs e)          //粗體
        {
            if (Bold.Checked == true)
            {
                bold = true;
                Word.ChangeStyle(bold, italic);
            }
            else
            {
                bold = false;
                Word.ChangeStyle(bold, italic);
            }
            label.Font = Word.f;
        }

        private void Italic_CheckedChanged(object sender, EventArgs e)          //斜體
        {
            if (Italic.Checked == true)
            {
                italic = true;
                Word.ChangeStyle(bold, italic);
            }
            else
            {
                italic = false;
                Word.ChangeStyle(bold, italic);
            }
            label.Font = Word.f;
        }

        private void FontSize_TextChanged(object sender, EventArgs e)          //輸入文字大小，並判斷是否在範圍內
        {
            try
            {
                Word.Size = int.Parse(FontSize.Text);
                if (Word.Size >= 25 || Word.Size <= 1)
                    Word.Size = 12;
                Word.f = new Font(Word.Family, Word.Size, Word.Style);
                label.Font = Word.f;
            }
            catch(FormatException)
            {
                Word.f = new Font(Word.Family, 12, Word.Style);
                label.Font = Word.f;
            }
        }

        private void position1_CheckedChanged(object sender, EventArgs e)           //文字位置
        {
            Word.ChangeAlignment(0);
            label.TextAlign = Word.Alignment;
            label.Top = Word.y;
        }

        private void position2_CheckedChanged(object sender, EventArgs e)
        {
            Word.ChangeAlignment(1);
            label.TextAlign = Word.Alignment;
            label.Top = Word.y;
        }

        private void position3_CheckedChanged(object sender, EventArgs e)
        {
            Word.ChangeAlignment(2);
            label.TextAlign = Word.Alignment;
            label.Top = Word.y;
        }

        private void position4_CheckedChanged(object sender, EventArgs e)
        {
            Word.ChangeAlignment(3);
            label.TextAlign = Word.Alignment;
            label.Top = Word.y;
        }

        private void position5_CheckedChanged(object sender, EventArgs e)
        {
            Word.ChangeAlignment(4);
            label.TextAlign = Word.Alignment;
            label.Top = Word.y;
        }

        private void position6_CheckedChanged(object sender, EventArgs e)
        {
            Word.ChangeAlignment(5);
            label.TextAlign = Word.Alignment;
            label.Top = Word.y;
        }
    }

}
