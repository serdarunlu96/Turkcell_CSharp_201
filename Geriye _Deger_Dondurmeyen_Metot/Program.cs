namespace Geriye__Deger_Dondurmeyen_Metot
{
    public class Program
    {
        public static void yazdir()
        {
            Console.Write("Bu bir metottur.");
            Console.WriteLine();
            Console.WriteLine("Burası metodun bir başka satırıdır.");
            Console.WriteLine();

        }
        public static void Main(string[] args)
        {
            yazdir();
            Console.WriteLine("****************");
            Console.WriteLine();
            yazdir();
            Console.Read();  
        }
    }
}