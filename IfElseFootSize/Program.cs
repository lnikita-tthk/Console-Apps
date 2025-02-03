namespace IfElseFootSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta jalanumber: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 30 && number <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jalanumber on vahemikus 30-33.");
            }
            else if (number >= 34 && number <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Jalanumber on vahemikus 34-38.");
            }
            else if (number >= 39 && number <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jalanumber on vahemikus 39-44.");
            }
            else if (number >= 45 && number <= 48)
            {
                Console.Beep();
                Console.WriteLine("Jalanumber on vahemikus 45-48.");
            }
            else
            {
                Console.WriteLine("Jalanumber ei kuulu ühtegi määratud vahemikku.");
            }
        }
    }
}
