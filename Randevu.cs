using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restrand
{
    public  class Randevu:Restaurant
    {
        public object MusteriBilgileri { get; set; }

        public override string MasaKonumu()
        {
            throw new NotImplementedException();
        }

        public override int MasaSayisi()
        {
            throw new NotImplementedException();
        }

        public override object Menu()
        {
            throw new NotImplementedException();
        }

        public override int SandelyeSayisi()
        {
            throw new NotImplementedException();
        }
        private DateTime tarih;

        public DateTime Tarih
        {
            get { return tarih; }

            set { tarih = value; }
        }

    }
}