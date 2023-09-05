namespace Random_Uygulaması
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Random sınıf uygulaması
            int sayi;
            Random r = new Random();
            sayi = r.Next(0,51);
            Console.Write(sayi);

            Console.Read();
        }
    }
}