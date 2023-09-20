using System;
namespace Uppgift_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din beräkning med två tal som inne fattar en decimal ");
            string helaberäkning = Console.ReadLine();

            int gångerindex = helaberäkning.IndexOf("*");

            string tal1text = helaberäkning[..gångerindex];
            string tal2text = helaberäkning[(gångerindex + 1)..];
            double tal1 = double.Parse(tal1text);
            double tal2 = double.Parse(tal2text);
            double sum = tal1 * tal2;

            Console.WriteLine("svaret är " + sum);
            Console.ReadKey();
        }
    }
}