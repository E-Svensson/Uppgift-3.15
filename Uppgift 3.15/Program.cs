using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar tänker du hyra bilen i?");
            Console.Write("Svara här: "); int timmar = int.Parse(Console.ReadLine());

            if (timmar > 11)
            {
                Console.WriteLine("Du får tyvärr inte hyra bilen för mer än 11 timmar");
            }

            if (timmar < 12)
            {
                Console.WriteLine("Det kommer kosta dig " + timmar*80 + " kronor");
            }
        }
    }
}
