namespace NameControll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Programm kusib nime
            //kui sisestasid nime, siis konsool vastab
            //TERE, sinu nimi
            //peab kasutama if ja else
            //kui nime ei sisestada, siis tuleb vastuseks
            //ERROR ja konsool teeb Beep kolm korda

            Console.Write("Sisesta nimi ja vajuta enter: ");
            string name = Console.ReadLine();

            if(string.IsNullOrEmpty(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"TERE, {name}");
            }
        }
    }
}
