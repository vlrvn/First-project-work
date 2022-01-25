// See https://aka.ms/new-console-template for more information

using System;
namespace test73

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Номер тикита:");
            string? name = Console.ReadLine();
            Console.WriteLine($"build {name}");
        }
    }
}