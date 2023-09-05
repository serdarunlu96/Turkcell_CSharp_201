namespace Over_Flow_Exception
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
            catch (FormatException)
            {
                Console.WriteLine("Hata var, lutfen formatınızı kontrol ediniz.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Lutfen aralıgın dısında deger girmeyin.");
            }
            Console.Read();
        }
    }
}