using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catching
{
    class bullet : item
    {

        protected new int itemSize = 20;

        public new int ItemSize
        {
            get { return itemSize; }
            set { itemSize = value; }
        }
    }
}
