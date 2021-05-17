using System;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            NovacA a = new NovacA();
            a.Iznos = 100;
            Console.WriteLine(a.ConvertToHRK(Convert.ToDecimal(7.55)));
        }
    }
}
