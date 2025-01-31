﻿namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kasutaja kontroll!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello {0}, you are {1} years old!", name, age);
            Console.WriteLine("Hello "+name+", you are "+age+" years old!");

            if (age < 7 && age > 0)
            {
                Console.WriteLine("Loodan, et juba kaid koolis");
            }
            else if (age >= 7 && age <= 18)
            {
                Console.WriteLine("Kaid koolis"); 
            }
            else if (age > 18 && age <= 75)
            {
                Console.WriteLine("Oled tootaja");
            }
            else if (age > 75 && age <= 130)
            {
                Console.WriteLine("Puhkad soojal maal");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
