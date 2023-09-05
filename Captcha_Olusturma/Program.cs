namespace Captcha_Olusturma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Captcha
            int d1,d2,d3,d4;
            Random rnd = new Random();
            d1 = rnd.Next(0,10);
            d2 = rnd.Next(0, 10);
            d3 = rnd.Next(0, 10);
            d4 = rnd.Next(0, 10);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            string[] kararkterler = { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E" };
            Console.Write(d1 + kararkterler[d2] + d3 + kararkterler[d4]);
            Console.Read();
        }
    }
}