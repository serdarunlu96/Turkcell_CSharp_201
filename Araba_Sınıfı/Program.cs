namespace Araba_Sınıfı
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.marka = "Audi";
            araba.hiz = 240;
            araba.model = "2002";
            araba.motor = 1.6;
            araba.renk = "Beyaz";

            Console.Write("*********** Araba Tanıtım Kartı 1 ***************");
            Console.WriteLine();
            Console.WriteLine("Marka: " + araba.marka);
            Console.WriteLine("Hız: " + araba.hiz);
            Console.WriteLine("Model: " + araba.model);
            Console.WriteLine("Motor: " + araba.motor);
            Console.WriteLine("Renk: " + araba.renk);

        }
    }
}