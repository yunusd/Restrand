using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restrand
{
    public abstract class Restaurant
    {
        public abstract int MasaSayisi();
        public abstract int SandelyeSayisi();
        public abstract string MasaKonumu();
        public abstract object Menu();
    }
}