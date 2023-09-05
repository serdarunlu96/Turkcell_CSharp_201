namespace Tarih_Zaman_Fonksiyonlar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Datetime
            Console.WriteLine("Bugunun gun bilgisi: " + DateTime.Now.Day);
            Console.WriteLine("Bugunun ay bilgisi: " + DateTime.Now.Month);
            Console.WriteLine("Bugunun yıl bilgisi: " + DateTime.Now.Year);
            Console.WriteLine("Bugunun saat bilgisi: " + DateTime.Now.Hour);
            Console.WriteLine("Bugunun dakika bilgisi: " + DateTime.Now.Minute);
            Console.WriteLine("Bugunun saniye bilgisi: " + DateTime.Now.Second);
            Console.WriteLine("Bugunun kısa tarih bilgisi: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Bugunun uzun tarih bilgisi: " + DateTime.Now.ToLongDateString());
            
            Console.Read();
        }
    }
}