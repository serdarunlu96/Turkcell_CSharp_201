namespace Geriye_Deger_Dondurmeyen_Metotlarda_Parametrenin_Klavyeden_Alınması
{
    public class Program
    {
        public static void MetinYaz2(string parametre)
        {
            Console.Write("*************");
            Console.WriteLine();
            Console.Write(parametre);
            Console.WriteLine();
            Console.Write("*************");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Kelimeyi giriniz: ");
            string kelime = Console.ReadLine();

            MetinYaz2(kelime);
            Console.Read();
        }
    }
}