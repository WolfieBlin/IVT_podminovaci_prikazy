using System;

namespace IVT_podminovaci_prikazy
{
    public class Klakulačka : Vstupy
    {
        private double _a;
        private double _b;
        
        public void Vypocet()
        {
                var pokracovat = true;
            
                Console.WriteLine("Zadejte první číslo");
                _a = Test();
            
                Console.WriteLine("Zadejte druhé číslo");
                _b = Test();
            
                Console.WriteLine("Zadejte operaci:");
                Console.WriteLine("1 - sčítání");
                Console.WriteLine("2 - odčítání");
                Console.WriteLine("3 - násobení");
                Console.WriteLine("4 - dělení");
            
                var volba = Convert.ToString(Console.ReadLine());
            
                Console.WriteLine();
            
                double vysledek = 0;
            
                while (pokracovat)
                {
                    switch (volba)
                    {
                        case "1":
                            vysledek = _a + _b;
                            pokracovat = false;
                            break;
                        case "2":
                            vysledek = _a - _b;
                            pokracovat = false;
                            break;
                        case "3":
                            vysledek = _a * _b;
                            pokracovat = false;
                            break;
                        case "4":
                            vysledek = _a / _b;
                            pokracovat = false;
                            break;
                        default:
                            Console.WriteLine("Špatná volba zkuste to znovu");
                            break;
                    }
                }

                Console.WriteLine("Výsledek je " + vysledek.ToString());
        }
    }
}