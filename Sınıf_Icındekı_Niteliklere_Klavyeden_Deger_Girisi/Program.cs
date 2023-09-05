using Musteri_Sınıfı;

namespace Sınıf_Icındekı_Niteliklere_Klavyeden_Deger_Girisi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Console.Write("Id Degeri giriniz: ");
            musteri.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adınızı giriniz: ");
            musteri.ad = Console.ReadLine();
            Console.Write("Soyadınızı giriniz: ");
            musteri.soyad = Console.ReadLine();
            Console.Write("Sehrinizi giriniz: ");
            musteri.sehir = Console.ReadLine();


            Console.Write("*********** Musteri Tanıtım Kartı 2 ***************");
            Console.WriteLine();
            Console.WriteLine(musteri.id + " Ad Soyad: " + musteri.ad + " " + musteri.soyad + " Sehir: " + musteri.sehir);
            Console.WriteLine();

            Console.Read();
        }
    }
}