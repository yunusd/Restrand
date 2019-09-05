using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restrand
{
    public abstract class Istatistik:Restaurant
    {
        public int RandevuAdet { get; set; }
        public int BasariliRandevu { get; set; }
    }
}