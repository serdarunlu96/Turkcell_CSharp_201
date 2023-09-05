using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Treading.Tasks;
using System.IO;

namespace Metin_Belgesini_Okuma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"Masaüstü dizini yaz", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string metin = sr.ReadLine();
            while (metin != null)
            {
                Console.WriteLine(metin);
                metin = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            Console.Read();
        }
    }
}