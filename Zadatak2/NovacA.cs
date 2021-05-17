using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class NovacA : IConvert
    {
        public decimal Iznos { get; set; }
        public decimal ConvertToHRK(decimal tecaj)
        {
            return Iznos * tecaj;
        }
    }
}
