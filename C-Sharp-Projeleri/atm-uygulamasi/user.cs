using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_uygulamasi
{
    internal class user
    {
        private int identity;
        private string ad;
        private string soyad;
        private double bakiye;

        public int Identity { get => identity; set => identity = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }

        public user(string ad, string soyad, double bakiye)
        {
            Random random = new Random();
            this.identity = random.Next(1000, 9999);
            this.Ad = ad;
            this.Soyad = soyad;
            this.Bakiye = bakiye;
        }
    }
}
