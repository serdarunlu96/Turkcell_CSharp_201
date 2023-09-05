namespace String_Fonksiyon_1
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

            Console.WriteLine("Concat ile birlestirme: " + string.Concat(metin,metin2));
            Console.WriteLine("Metin 1 icin karakter sayisi: " + metin.Length);
            Console.WriteLine("IndexOf ornegi: " + metin.IndexOf("is"));
            Console.ReadLine();
        }
    }
}