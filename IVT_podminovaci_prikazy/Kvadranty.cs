using System;
using System.Runtime.InteropServices.ComTypes;

namespace IVT_podminovaci_prikazy
{
    public class Kvadranty : Vstupy
    {
        private double _x;
        private double _y;
        
        public void Vypocet()
        {
           // var test = new Vstupy();
            Console.WriteLine("Zadejte souřadnice bodu X a Y");
            _x = Test();
            _y = Test();

            if (_x > 0)
            {
                if (_y > 0)
                {
                    Console.WriteLine("Bod se nachází v prvním kvadrantu");
                }
                else
                {
                    Console.WriteLine("Bod se nachází ve čtvrtém kvadravnu");
                }
            }
            else
            {
                if (_y > 0)
                {
                    Console.WriteLine("Bod se nachází v druhém kvadrantu");
                }
                else
                {
                    Console.WriteLine("Bod se nachází ve třetím kvadravnu");
                }

            }

            
        }
    }
}