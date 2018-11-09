using System;
using System.Runtime.InteropServices.ComTypes;

namespace IVT_podminovaci_prikazy
{
    public class Kvadranty : Vstupy
    {
        private double _x;
        private double _y;
        private byte kvadrant;
        
        public void Vypocet()
        {
            Console.WriteLine("Zadejte souřadnice bodu X a Y");
            
            _x = Test();
            _y = Test();

            if (_x > 0)
            {
                if (_y > 0)
                {
                    kvadrant = 1;
                }
                else
                {
                    kvadrant = 4;
                }
            }
            else
            {
                if (_y > 0)
                {
                    kvadrant = 2;
                }
                else
                {
                    kvadrant = 3;
                }

            }

            Console.WriteLine("Bod se nachází v {0}. kvadrantu", kvadrant);
            
        }
    }
}