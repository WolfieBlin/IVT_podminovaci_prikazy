using System;
using System.ComponentModel;

namespace IVT_podminovaci_prikazy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
                var pokracovat = true;

            while (pokracovat)
            {
                Console.WriteLine("Vyberte si operaci:");
                Console.WriteLine("1 - Lineární rovnice\n2 - Kvadratická rovnice\n3 - Kvadranty\n4 - Kalkulačka\n5 - Trojúhelník zkouška\n6 - Největší a nejmenší");
                var input = Convert.ToString(Console.ReadLine());

                switch (input)
                {
                    case "1":
                        var linearniRovnice = new LinearniRovnice();
                        linearniRovnice.Vypocet();
                        break;
                    case "2":
                        var kvadratickaRovnice = new KvadratickaRovnice();
                        kvadratickaRovnice.Vypocet();
                        break;
                    case "3":
                        var kvadranty = new Kvadranty();
                        kvadranty.Vypocet();
                        break;
                    case "4":
                        var kalkulačka = new Klakulačka();
                        kalkulačka.Vypocet();
                        break;
                    case "5":
                        var trojúhelník = new Trojúhelník();
                        trojúhelník.Vypocet();
                        break;
                    case "6":
                        var nejmensiNejvetsi = new NejmensiNejvetsi();
                        nejmensiNejvetsi.Vypocet();
                        break;
                    default:
                        Console.WriteLine("Špatná volba");
                        break;
                }

                Console.WriteLine("Chcete pokračovat? [a/n]");
                var platnaVolba = false;
                while (!platnaVolba)
                {
                    switch (Convert.ToString(Console.ReadLine()))
                    {
                        case "a":
                            pokracovat = true;
                            platnaVolba = true;
                            break;
                        case "n":
                            pokracovat = false;
                            platnaVolba = true;
                            break;
                        default:
                            Console.WriteLine("Neplatná volba, zadejte prosím a/n");
                            break;
                    }
                }
            }
            }
            
        }
    }