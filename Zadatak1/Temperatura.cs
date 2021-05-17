using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Temperatura: IComparable<Temperatura>
    {
        public int Temp { get; set; }
        public int Kelvin { get; set; }
        public int Celzijus { get; set; }

        public Temperatura(int temp)
        {
            this.Temp = temp;
        }
        public int CompareTo(Temperatura other)
        {
            if (this.Temp==other.Temp)
            {
                return 0;
            }
            else if(this.Temp>other.Temp)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
