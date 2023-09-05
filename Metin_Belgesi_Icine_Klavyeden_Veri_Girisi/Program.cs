using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Treading.Tasks;
using System.IO;

namespace Metin_Belgesi_Icine_Klavyeden_Veri_Girisi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Masaüstü dizini yaz");
            string metin;
            Console.Write("Metni giriniz: ");
            metin = Console.ReadLine();
            sw.Write(metin);
            sw.Close();
            Console.Read();
        }
    }
}