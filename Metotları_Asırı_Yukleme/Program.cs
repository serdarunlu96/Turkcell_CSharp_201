namespace Metotları_Asırı_Yukleme
{
    public class Program
    {
        public static int Ortalama(int s1, int s2)
        {
            int sonuc = (s1 + s2) / 2;
            return sonuc;
        }

        public static int Ortalama(int s1, int s2, int s3)
        {
            int sonuc = (s1 + s2 + s3) / 3;
            return sonuc;
        }

        public static void Main(string[] args)
        {
            // Console.Write("Ortalama: " + Ortalama(50,85));
            Console.Write("Ortalama: " + Ortalama(40, 50, 68));
            Console.Read();
        }
    }
}