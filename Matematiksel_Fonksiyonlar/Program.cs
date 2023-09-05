namespace Matematiksel_Fonksiyonlar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Math
            double sayi;
            Console.Write("Sayiyi giriniz: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mutlak deger: " + Math.Abs(sayi));
            Console.WriteLine("Ust taban: " + Math.Ceiling(sayi));
            Console.WriteLine("Alt taban: " + Math.Floor(sayi));
            Console.WriteLine("Karekok: " + Math.Sqrt(sayi));

            Console.Read();
        }
    }
}