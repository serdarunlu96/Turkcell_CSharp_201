namespace Musteri_Sınıfı
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.ad = "Serdar";
            musteri.soyad = "Unlu";
            musteri.id = 1;
            musteri.sehir = "Ankara";

            Console.Write("*********** Musteri Tanıtım Kartı 1 ***************");
            Console.WriteLine();
            Console.WriteLine(musteri.id + " Ad Soyad: " + musteri.ad + " " + musteri.soyad + " Sehir: " + musteri.sehir);
            Console.WriteLine();

            Console.Read();
        }
    }
}