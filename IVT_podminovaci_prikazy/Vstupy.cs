using System;

namespace IVT_podminovaci_prikazy
{
    public class Vstupy
    {
        //Tuhle classu jsem pomocí dědičnosti implementoval do všech výpočetních class
        
        private double _vstup;
        
        // metoda testuje vstup uživatele jestli to je číslo a pokud jo vrátí to číslo
        public double Test()
        {
            while (!double.TryParse(Console.ReadLine(), out _vstup))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
            return _vstup;
        }
    }
}