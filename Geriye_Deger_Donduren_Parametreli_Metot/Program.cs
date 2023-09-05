namespace Geriye_Deger_Donduren_Parametreli_Metot
{
    public class Program
    {
        public static int Toplam(int s1, int s2)
        {
            int sonuc;
            sonuc = s1 + s2;
            return sonuc;
        }
        public static void Main(string[] args)
        {
            // Console.Write("Toplam: " + Toplam(10,15));
            int sayi1, sayi2;
            Console.Write("1. sayiyi giriniz: ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. sayiyi giriniz: ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sonuc: " + Toplam(sayi1,sayi2));
            Console.WriteLine(Toplam(7,8));
            Console.Read();
        }
    }
}