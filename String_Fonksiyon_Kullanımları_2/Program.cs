namespace String_Fonksiyon_Kullanımları_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Metinsel fonksiyonlar
            string metin, metin2;
            Console.Write("Metni giriniz: ");
            metin = Console.ReadLine();
            Console.Write("Metni giriniz: ");
            metin2 = Console.ReadLine();

            Console.WriteLine("Concat ile birlestirme: " + string.Concat(metin, metin2));
            Console.WriteLine("Metin 1 icin karakter sayisi: " + metin.Length);
            Console.WriteLine("IndexOf ornegi: " + metin.IndexOf("is"));
            Console.WriteLine("Satrtswith ornegi: " + metin.StartsWith("merhaba"));
            Console.WriteLine("merhaba dunya: " + metin.Trim());
            Console.WriteLine("Buyuk harf: " + metin.ToUpper());
            Console.WriteLine("Kucuk harf: " + metin.ToLower());
            Console.WriteLine("Remove metodu: " + metin.Remove(4));
            Console.WriteLine("Replace metodu: " + metin.Replace("a","A"));
            Console.WriteLine("Substring metodu:" + metin.Substring(4));

            Console.ReadLine();
        }
    }
}