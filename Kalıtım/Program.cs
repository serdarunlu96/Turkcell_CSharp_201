namespace Kalıtım
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
            papagan.ses = "Cik";
            papagan.agirlik = 1650;

            Console.WriteLine("Tur: " + papagan.tur);
            Console.WriteLine("Hiz: " + papagan.hiz);
            Console.WriteLine("İsim: " + papagan.isim);
            Console.WriteLine("Renk: " + papagan.renk);
            Console.WriteLine("Ses: " + papagan.ses);
            Console.WriteLine("Agirlik: " + papagan.agirlik);
        }
    }
}