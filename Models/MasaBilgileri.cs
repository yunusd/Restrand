using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restrand
{
    public class MasaBilgileri
    {
        static int masaSayisi = 0;
        public int MasaSayisi()
        {
           return masaSayisi;
        }

        public MasaBilgileri()
        {
            // Her örnek oluşturulduğunda masa sayısını 1 artır
            masaSayisi++;
        }

        public int sandalyeSayisi;
        public string masaKonumu;

        public override string ToString()
        {
            return $"Konum: {masaKonumu}, San: {sandalyeSayisi}";
        }
    }
}