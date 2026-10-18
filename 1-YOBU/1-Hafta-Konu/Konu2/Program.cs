using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
    {
        int kisaKenar = Convert.ToInt32(Console.ReadLine());
        int uzunKenar = Convert.ToInt32(Console.ReadLine());
        int alan = kisaKenar * uzunKenar;
        Console.WriteLine("Dikdörtgenin alani: " + alan);
    }
}
}   