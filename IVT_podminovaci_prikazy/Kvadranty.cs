using System;
using System.Runtime.InteropServices.ComTypes;

namespace IVT_podminovaci_prikazy
{
    public class Kvadranty
    {
        private double _x;
        private double _y;
        
        public void Vypocet()
        {
            var test = new Vstupy();
            Console.WriteLine("Zadejte souřadnice bodu X a Y");
            _x = test.Test();
            _y = test.Test();

            if (_x < 0 && _y != 0)
            {
                Console.WriteLine(_y < 0 ? "Bod se nachází v třetím kvadrantu" : "Bod se nachází v druhém kvadrantu");
            }
             if(_y !=0 && _x >0)
            {
                Console.WriteLine(_y < 0 ? "Bod se nachází v čtvrtém kvadrantu" : "Bod se nachází v prvním kvadrantu");
            }
            if (_x == 0 && _y != 0)
            {
                Console.WriteLine("Bod se nachází na ose y");
            }
            if(_x != 0 && _y == 0)
            {
                Console.WriteLine("Bod se nachází na ose x");
            }
            if(_x == 0&& _y==0)
            {
                Console.WriteLine("Bod se nachází v počátku soustavy");
            }
        }
    }
}