using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace IVT_podminovaci_prikazy
{
    public class NejmensiNejvetsi : Vstupy
    {
        private double _a;
        private double _b;
        private double _c;
        private double _d;
        
        private List<double> _list = new List<double>();

        public void Vypocet()
        {
            //List<double> list = new List<double>();

            Console.WriteLine("Zadejte postupně 4 čísla");
            _a = Test();
            _list.Add(_a);

            _b = Test();
            _list.Add(_b);

            _c = Test();
            _list.Add(_c);

            _d = Test();
            _list.Add(_d);

            var max = _list.Max();
            var min = _list.Min();

            Console.WriteLine("Největší čísli je {0} a nejmenší je {1}", max.ToString(), min.ToString());
        }
    }
}