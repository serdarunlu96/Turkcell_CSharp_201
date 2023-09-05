namespace Random_Sınıfı_Ile_Dizi_Kullanımları
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rn = new Random();
            int sehir;
            string[] sehirler = { "Adana", "Ankara", "Bursa", "Istanbul" };
            sehir = rn.Next(0,sehirler.Length);
            Console.WriteLine(sehirler[sehir]);

            Console.Read();
        }
    }
}