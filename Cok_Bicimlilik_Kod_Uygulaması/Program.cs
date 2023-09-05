namespace Cok_Bicimlilik_Kod_Uygulaması
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Papagan papagan = new Papagan();
            papagan.tur = "Papagan";
            papagan.hiz = 50;
            papagan.isim = "Sakir";
            papagan.renk = "Sarı-Kırmızı";
            papagan.agirlik = 1650;
            papagan.sesCikar();

            Console.WriteLine("Tur: " + papagan.tur);
            Console.WriteLine("Hiz: " + papagan.hiz);
            Console.WriteLine("İsim: " + papagan.isim);
            Console.WriteLine("Renk: " + papagan.renk);
            Console.WriteLine("Ses: " + papagan.sesCikar());
            Console.WriteLine("Agirlik: " + papagan.agirlik);

            Console.WriteLine("********************************");

            Karga karga = new Karga();
            karga.tur = "Karga";
            karga.hiz = 80;
            karga.isim = "Alacakarga";
            karga.renk = "Siyah";
            karga.agirlik = 1350;
            karga.sesCikar();

            Console.WriteLine("Tur: " + karga.tur);
            Console.WriteLine("Hiz: " + karga.hiz);
            Console.WriteLine("İsim: " + karga.isim);
            Console.WriteLine("Renk: " + karga.renk);
            Console.WriteLine("Ses: " + karga.sesCikar());
            Console.WriteLine("Agirlik: " + karga.agirlik);
        }
    }
}