using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace IVT_podminovaci_prikazy
{
    public class NejmensiNejvetsi : Vstupy
    {

        private double[] _array = new double[4];
        
        public void Vypocet()
        {
            Console.WriteLine("Zadejte postupně 4 čísla");
            
            for (int i = 0; i < 4; i++)
            {
                _array[i] = Test();
            }
            
            var max = _array.Max();
            var min = _array.Min();

            Console.WriteLine("Největší čísli je {0} a nejmenší je {1}", max.ToString(), min.ToString());
        }
    }
}