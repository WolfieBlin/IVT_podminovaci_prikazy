using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IVT_podminovaci_prikazy
{
    public class LinearniRovnice
    {
        private double _a;
        private double _b;
       
        public void Vypocet()
        {
            var test = new Vstupy();
            Console.WriteLine("Zadejte proměnou a , b podle rovnice ax + b = 0");
            _a = test.Test();
            _b = test.Test();

            var vysledek = -_b/_a;
            Console.Write("X = "+vysledek.ToString());
        }

        public void VypocetKvadraticka(double a, double b)
        {
            var vysledek = -b / a;
            Console.WriteLine("X = " + vysledek.ToString());
        }
    }
}