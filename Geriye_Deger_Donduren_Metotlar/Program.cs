namespace Geriye_Deger_Donduren_Metotlar
{
    public class Program
    {
        public static int Toplama()
        {
            int sayi1, sayi2, sonuc;
            sayi1 = 25;
            sayi2 = 35;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public static void Main(string[] args)
        {
            Console.Write(Toplama());
            Console.Read();
        }
    }
}