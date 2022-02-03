using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one
{
    class Journal
    {
      

        public int Value { get; set; }

        public static int operator +(Journal a, int x)
        {
            return a.Value + x;
        }
        public static Journal operator +(Journal a, Journal b)
        {
            return new Journal { Value = a.Value + b.Value };
        }
        public static Journal operator -(Journal a, Journal b)
        {
            return new Journal  {Value = a.Value - b.Value};
        }
        public static int operator - (Journal a, int x)
        {
            return a.Value - x;
        }
        public static bool operator > (Journal a, int x)
        {
            if (a.Value  > x)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static bool operator <(Journal a, int x)
        {
            if (a.Value < x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override bool Equals(object obj)              // переопределение метода Equals
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()             // необходимо также переопределить метод GetHashCode
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Journal a, Journal b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Journal a, Journal b)
        {
            return !(a == b);
        }



    }
}
