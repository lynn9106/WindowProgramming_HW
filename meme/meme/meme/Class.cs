using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


namespace meme
{
    class Class
    {
        public int Size;
        public FontFamily Family;
        public FontStyle Style;
        public ContentAlignment Alignment;
        public int y; 
        public Font f;

        public Class()                  //預設
        {
            f = new Font("標楷體", 12, FontStyle.Regular);
            Family = f.FontFamily;
            Size = 12;
            Style = f.Style;
            Alignment = ContentAlignment.TopLeft;
            y = 30;
          }
        public void ChangeAlignment(int type)           //改變位置
        {
            if (type % 3 == 0)
                Alignment = ContentAlignment.TopLeft;           //左右
            else if (type % 3 == 1)
                Alignment = ContentAlignment.TopCenter;
            else
                Alignment = ContentAlignment.TopRight;

            if (type / 3 == 0)              //上下
                y = 30;
            else
                y = 250;
        }

        public void ChangeFamily(string newFamily)          //改變字體
        {
            Family = new FontFamily(newFamily);
            f = new Font(Family, Size, Style);
        }

        public void ChangeStyle(bool bold,bool italic)          //粗體、斜體
        {
            if (bold == true && italic == false) Style = FontStyle.Bold;
            else if (bold == true && italic == true) Style = FontStyle.Bold | FontStyle.Italic;
            else if (bold == false && italic == true) Style = FontStyle.Italic;
            else Style = FontStyle.Regular;
            f = new Font(Family, Size, Style);
        }















    }
}
