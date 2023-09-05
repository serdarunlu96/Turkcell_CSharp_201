using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cok_Bicimlilik_Kod_Uygulaması
{
    public class Kuslar
    {
        public string tur;
        // public string ses;
        public int hiz;
        public double agirlik;

        public virtual string sesCikar()
        {
            return "buraya ses yazilicak";
        }
    }
}
