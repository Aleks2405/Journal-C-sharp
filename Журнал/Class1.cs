using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one
{
    class Journal
    {
        private int quantity;

        public bool oper;

        public Journal(int quantity) { this.quantity = quantity; }

        public static int operator +(Journal a, int x)
        {
            return a.quantity + x;
        }
        public static int operator - (Journal a, int x)
        {
            return a.quantity - x;
        }
      
        
    }
}
