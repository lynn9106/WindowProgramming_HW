using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    class Card : Button
    {
        public int number;
        private int num1;
        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        private int num2;
        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public void hideNumber()
        {
            this.Text = "";
            this.BackColor = DefaultBackColor;
        }

        public void showNumber()
        {
            this.Text= Convert.ToString(number);
            this.BackColor = Color.CornflowerBlue;
        }




    }
}
