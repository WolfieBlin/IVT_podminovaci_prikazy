using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace IVT_podminovaci_prikazy
{
    public class NejmensiNejvetsi
    {
        public void Vypocet()
        {
            List<double> list = new List<double>();

            Console.WriteLine("Zadejte postupně 4 čísla");
            var a = Convert.ToDouble(Console.ReadLine());
            list.Add(a);

            var b = Convert.ToDouble(Console.ReadLine());
            list.Add(b);

            var c = Convert.ToDouble(Console.ReadLine());
            list.Add(c);

            var d = Convert.ToDouble(Console.ReadLine());
            list.Add(d);

            var max = list.Max();
            var min = list.Min();

            Console.WriteLine("Největší čísli je {0} a nejmenší je {1}", max.ToString(), min.ToString());
        }
    }
}