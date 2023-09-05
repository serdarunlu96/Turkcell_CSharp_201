using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    public class Musteri
    {
        public int id;
        public string ad;
        public string soyad;
        public string sehir;

        public string Ad { get => ad; set => ad = value.ToLower(); }

        public string Soyad { 
            get => soyad; 
            set => soyad = value.ToUpper(); 
        }
    }
}
