namespace Time_Span_Kullanımı
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Time span
            TimeSpan zaman;
            int gunFarki;
            DateTime tarih1, tarih2;
            tarih1 = Convert.ToDateTime("01.01.2020");
            tarih2 = Convert.ToDateTime("15.01.2020");
            zaman = tarih2 - tarih1;
            gunFarki = zaman.Days;
            Console.Write("Fark:" + gunFarki);

            Console.Read();
        }
    }
}