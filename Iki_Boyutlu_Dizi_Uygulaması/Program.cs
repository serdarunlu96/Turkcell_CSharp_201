namespace Iki_Boyutlu_Dizi_Uygulaması
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Cok boyutlu diziler
            int[,] sayilar = new int[2, 3];
            sayilar[0, 0] = 10;
            sayilar[0, 1] = 20;
            sayilar[0, 2] = 25;
            sayilar[1, 0] = 30;
            sayilar[1, 1] = 40;
            sayilar[1, 2] = 45;
            Console.Write(sayilar[0,1]);
            Console.Read();
        }
    }
}