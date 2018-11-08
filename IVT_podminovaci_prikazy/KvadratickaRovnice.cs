using System;
using System.ComponentModel;

namespace IVT_podminovaci_prikazy
{
    public class KvadratickaRovnice : Vstupy, ILinearniRovniceVypocet
    {
        private ILinearniRovniceVypocet _vypocet = new LinearniRovnice();
        
        private double _a;
        private double _b;
        private double _c;
        
        public void VypocetKvadraticka()
        {
            //var test = new Vstupy();
            Console.WriteLine("Zadejte proměnou a , b a c podle rovnice ax2 + bx + c = 0");
            _a = Test();
            _b = Test();
            _c = Test();
            var diskriminant = _b * _b - 4 * _a * _c;
            if (_a == 0)
            {
                VypocetKvadratickaLinearni(_b, _c);
            }
            else if (diskriminant > 0)
            {
                var vysledek1 = (-_b + Math.Sqrt(diskriminant)) / 2 * _a;
                var vysledek2 = (-_b - Math.Sqrt(diskriminant)) / 2 * _a;
                Console.WriteLine("X1 = {0}, X2 = {1}", vysledek1.ToString(),vysledek2.ToString());
            }
            else if (diskriminant == 0)
            {
                var vysledek = -_b / 2 * _a;
                Console.WriteLine("Tato rovnice má jeden kořen: X = "+ vysledek.ToString());
            }
            else
            {
                Console.WriteLine("Tato rovnice nemá řešení v R");
            }
        }

        public void VypocetKvadratickaLinearni(double a, double b)
        {
            _vypocet.VypocetKvadratickaLinearni(a,b);
        }
    }
}