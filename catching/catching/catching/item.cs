using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catching
{
    class item
    {
        protected int property=0;       //物件屬性;水(0)火(1)木(2)
        private int speed=0;          //速度
        protected int itemSize=40;
        public int Property
        {
            get
            {
                return property;
            }
            set
            {
                property = value;
            }
        }

        public int Speed(int Prop)
        {
            switch(Prop)
            {
                case 0:
                    speed = 10;
                    break;
                case 1:
                    speed = 20;
                    break;
                case 2:
                    speed = 30;
                    break;
            }
            return speed;
        }

        public int ItemSize
        {
            get { return itemSize; }
            set { itemSize = value; }
        }

    }
}
