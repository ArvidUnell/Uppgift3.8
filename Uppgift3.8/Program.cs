using System;
namespace Uppgift3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv 3 olika ord på var sin rad");
            string ord1 = Console.ReadLine();
            string ord2 = Console.ReadLine();
            string ord3 = Console.ReadLine();

            if (ord1.CompareTo(ord2)<0 && ord1.CompareTo(ord3)<0)
            {
                Console.WriteLine($"{ord1} kommer först i bokstavsordning.");
            }
            else if (ord2.CompareTo(ord3) < 0)
            {
                Console.WriteLine($"{ord2} kommer först i bokstavsordning.");
            }
            else
            {
                Console.WriteLine($"{ord3} kommer först i bokstavsordning.");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta.");
            Console.ReadKey();
        }
    }
}