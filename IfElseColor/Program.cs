namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Teha if ja else konsoolirakendus, kus " + 
            //    "kontrollitakse stringi abil värvi vastavust");

            //Console.WriteLine("Värvide valikuks on: red, blue, green ja white");
            
            //Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta " + 
            //   "eelpool sisestatud värvi");

            Console.WriteLine("Sisesta värv (red, blue, green, white):");
            string color = Console.ReadLine();

            if (color == "red")
            {
                Console.WriteLine("Värv on red");
            }
            else if (color == "blue")
            {
                Console.WriteLine("Värv on blue");
            }            
            else if (color == "green")
            {
                Console.WriteLine("Värv on green");
            }            
            else if (color == "white")
            {
                Console.WriteLine("Värv on white");
            }
            else
            {
                Console.WriteLine("Sisestasite kehtetu värvi. Palun sisestage üks järgmistest: red, blue, green, white.");
            }
        }
    }
}
