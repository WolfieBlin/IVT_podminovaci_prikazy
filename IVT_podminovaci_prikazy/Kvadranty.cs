using System;
using System.Runtime.InteropServices.ComTypes;

namespace IVT_podminovaci_prikazy
{
    public class Kvadranty : Vstupy
    {
        // nahoře se se přiřazují hodnoty se kterými se bude pracovat, deklarace proměných se většinou nedává do metod
        // káždý private prvek se označuje podržítkem před jménem, je to konvence
        
        private double _x;
        private double _y;
        private byte _kvadrant;
        
        //metoda která používá pomocí dědičnosti kontrolu vstupu a ukládá jí do privátní proměné této cllasy se kterou potom pracuje
        public void Vypocet()
        {
            Console.WriteLine("Zadejte souřadnice bodu X a Y");
            
            _x = Test();
            _y = Test();

            if (_x > 0)
            {
                if (_y > 0)
                {
                    _kvadrant = 1;
                }
                else
                {
                    _kvadrant = 4;
                }
            }
            else
            {
                if (_y > 0)
                {
                    _kvadrant = 2;
                }
                else
                {
                    _kvadrant = 3;
                }

            }

            Console.WriteLine("Bod se nachází v {0}. kvadrantu", _kvadrant);
            
        }
    }
}