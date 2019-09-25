using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restrand
{
    public abstract class Urun:Restaurant
    {
        public string UrunAdi { get; set; }
        public int UrunAdet { get; set; }
        public float UrunFiyat { get; set; }
    }
}