namespace MethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // kuidas kutsuda esile Main1 meetod siin:
            Main1();
        }

        static void Main1()
        {
            Console.WriteLine("Main1 method");
        }
    }
}
