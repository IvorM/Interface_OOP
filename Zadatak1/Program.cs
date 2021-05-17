using System;
using System.Collections.Generic;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Temperatura> temps = new List<Temperatura>()
            {
                new Temperatura(5),
                new Temperatura(8),
                new Temperatura(44),
                new Temperatura(4),
                new Temperatura(5),
                new Temperatura(6)

            };

            foreach (var item in temps)
            {
                Console.WriteLine(item.Temp);
            }

            temps.Sort();

            Console.WriteLine("\n");
            Console.WriteLine("Sorted list");
            foreach (var item in temps)
            {
                Console.WriteLine(item.Temp);
            }
            
        }
    }
}
