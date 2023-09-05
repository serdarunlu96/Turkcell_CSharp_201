namespace Exception_Kullanımı
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Hata yonetimi
            try
            {
                int sayi1, sayi2, sonuc;
                Console.Write("Sayi1: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sayi2: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                sonuc = sayi1 * sayi2;
                Console.Write("Islem sonucu: " + sonuc);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata var, lutfen formatınızı kontrol ediniz.");
                Console.Write(ex);
            }
            Console.Read();
        }
    }
}