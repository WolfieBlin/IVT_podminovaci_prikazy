using System;
using System.Data;

namespace IVT_podminovaci_prikazy
{
    public class Trojúhelník : Vstupy
    {
        private double _a;
        private double _b;
        private double _c;

        public void Vypocet()
        {
            Console.WriteLine("Zadejte strany a, b, c");
            //takhle by to vypadalo kdybych si neudělal classu na vstupy a musel bych to pokaždé vypsat
            
            /*while (!float.TryParse(Console.ReadLine(), out _a))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
            while (!float.TryParse(Console.ReadLine(), out _b))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
            while (!float.TryParse(Console.ReadLine(), out _c))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");*/
            
            //jednoduché použití pomocí jíné methody classy
            _a = Test();
            _b = Test();
            _c = Test();

            if ((_a + _b) > _c && (_a + _c) > _b && (_c + _b) > _a)
            {
                Console.WriteLine("Trojúhelník lze sestrojit");
            }
            else
            {
                Console.WriteLine("Trojúhelník nelze setrojit");
            }
        }
    }
}