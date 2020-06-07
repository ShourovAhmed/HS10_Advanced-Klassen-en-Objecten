using System;

namespace Meetlat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Meetlat m = new Meetlat(15);
            Console.WriteLine(m.LengteInCm);
            Console.WriteLine(m.LengteInKm);
            Console.WriteLine(m.LengteInVoet);
        }
    }
}
