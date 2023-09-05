namespace Geriye_Deger_Dondurmeyen_Metot__Ornek__2
{
    public class Program
    {
        public static void ToplamaMetodu()
        {
            int sayi1 = 24, sayi2 = 30;
            int toplam = sayi1 + sayi2;
            Console.Write(toplam);
        }

        public static void YaziBosluk()
        {
            Console.WriteLine();
            Console.Write("*********");
            Console.WriteLine();
        }

        public static void ArdisikSayilar()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " ");
            }
        }

        public static void Main(string[] args)
        {
            ToplamaMetodu();
            Console.WriteLine("**********");
            YaziBosluk();
            ArdisikSayilar();
            Console.Read();
        }
    }
}