using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IVT_podminovaci_prikazy
{
    public class LinearniRovnice : Vstupy, ILinearniRovniceVypocet
    {
        //interface se musí implementovat i do rodné classy
        
        private double _a;
        private double _b;
        private double _vysledek;
        
        public void Vypocet()
        {
            Console.WriteLine("Zadejte proměnou a , b podle rovnice ax + b = 0");
            
            _a = Test();
            _b = Test();

            if (_a == 0)
            {
                if (_b == 0)
                {
                    Console.WriteLine("Rovnice má nekonečno řešení");
                }
                else
                {
                    Console.WriteLine("Rovnice nemá řešení");
                }
            }
            else
            {
                _vysledek = -_b/_a;
                Console.WriteLine("X = "+ _vysledek.ToString());
            }
        }

        public void Vypocet(double a, double b)
        {
            //metoda pro výpočet pro kvadratickou
            //použil jsem polymorfismus, stejné označení metody ale podle vstupu se vybere která se použije
            
            _vysledek = -b / a;
            
            Console.WriteLine("Toto není kvadratická rovnice, ale lineární");
            Console.WriteLine("Výsledkem této lineární rovnice je");
                        
            Console.WriteLine("X = " + _vysledek.ToString());
        }
    }
}