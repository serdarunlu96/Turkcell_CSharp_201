using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Treading.Tasks;
using System.IO;

namespace Yeni_Metin_Belgesi_Icine_Yazı_Yazma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Masaüstü dizini yaz");
            sw.Write("Merhaba");
            sw.Close();
            Console.Read();
        }
    }
}