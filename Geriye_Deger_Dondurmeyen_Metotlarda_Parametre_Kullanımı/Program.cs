namespace Geriye_Deger_Dondurmeyen_Metotlarda_Parametre_Kullanımı
{
    public class Program
    {
        public static void MetinYaz(string p) 
        {
            Console.Write("*************");
            Console.WriteLine();
            Console.Write(p);
            Console.WriteLine();
            Console.Write("*************");
        }


        public static void Main(string[] args)
        {
            MetinYaz("Merhaba Turkcell Dersleri");

            Console.Read();
        }
    }
}