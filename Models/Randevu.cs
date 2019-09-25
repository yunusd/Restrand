using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restrand
{
    public  class Randevu:Restaurant
    {
        public override int MasaSayisi()
        {
            throw new NotImplementedException();
        }

        public override int SandelyeSayisi()
        {
            throw new NotImplementedException();
        }

        public override string MasaKonumu()
        {
            throw new NotImplementedException();
        }

        public override object Menu()
        {
            throw new NotImplementedException();
        }
        public object MusteriBilgileri { get; set; }
        private DateTime tarih;

        public DateTime Tarih
        {
            get { return tarih; }

            set { tarih = value; }
        }
    }
}