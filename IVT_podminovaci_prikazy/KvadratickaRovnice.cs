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
        
        private double _diskriminant;
        
        private double _x1;
        private double _x2;
        private double _x;
        
        public void VypocetKvadraticka()
        {
            Console.WriteLine("Zadejte proměnou a , b a c podle rovnice ax2 + bx + c = 0");
            
            _a = Test();
            _b = Test();
            _c = Test();
            
            _diskriminant = _b * _b - 4 * _a * _c;
            
            if (_a == 0)
            {
                Vypocet(_b, _c);
            }
            else if (_diskriminant > 0)
            {
                _x1 = (-_b + Math.Sqrt(_diskriminant)) / 2 * _a;
                _x2 = (-_b - Math.Sqrt(_diskriminant)) / 2 * _a;
                Console.WriteLine("X1 = {0}, X2 = {1}", _x1.ToString(),_x2.ToString());
            }
            else if (_diskriminant == 0)
            {
                _x = -_b / 2 * _a;
                Console.WriteLine("Tato rovnice má jeden kořen: X = "+ _x.ToString());
            }
            else
            {
                Console.WriteLine("Tato rovnice nemá řešení v R");
            }
        }

        public void Vypocet(double a, double b)
        {
            _vypocet.Vypocet(a,b);
        }
    }
}