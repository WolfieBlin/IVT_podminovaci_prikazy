using System;

namespace IVT_podminovaci_prikazy
{
    public class Vstupy
    {
        private double _vstup;
        
        public double Test()
        {
            while (!double.TryParse(Console.ReadLine(), out _vstup))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
            return _vstup;
        }
    }
}