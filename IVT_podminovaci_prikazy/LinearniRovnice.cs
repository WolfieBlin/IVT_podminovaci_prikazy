using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IVT_podminovaci_prikazy
{
    public class LinearniRovnice : Vstupy, ILinearniRovniceVypocet
    {
        private double _a;
        private double _b;
       
        public void Vypocet()
        {
            //var test = new Vstupy();
            Console.WriteLine("Zadejte proměnou a , b podle rovnice ax + b = 0");
            
            _a = Test();
            _b = Test();

            var vysledek = -_b/_a;
            Console.WriteLine("X = "+ vysledek.ToString());
        }

        public void VypocetKvadratickaLinearni(double a, double b)
        {
            var vysledek = -b / a;
            
            Console.WriteLine("Toto není kvadratická rovnice, ale lineární");
            Console.WriteLine("Výsledkem této lineární rovnice je");
                        
            Console.WriteLine("X = " + vysledek.ToString());
        }
    }
}