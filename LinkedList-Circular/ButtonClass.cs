using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Circular
{
    class ButtonClass : System.Windows.Forms.Button
    {
        public ButtonClass(string item)
        {
            this.Text = item;
            this.Width = 50;
            this.Height = 50;
            this.Name = item;
        }
    }
}
