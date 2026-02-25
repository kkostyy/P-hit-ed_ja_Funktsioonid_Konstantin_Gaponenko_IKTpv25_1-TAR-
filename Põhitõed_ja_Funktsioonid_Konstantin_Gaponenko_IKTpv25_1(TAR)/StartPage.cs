using Põhitõed_ja_Funktsioonid_Konstantin_Gaponenko_IKTpv25_1_TAR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Põhitõed_ja_Funktsioonid_Konstantin_Gaponenko_IKTpv25_1_TAR
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            bool tootan = true;

            while (tootan)
            {
                Console.WriteLine("\nPEAMENÜÜ");
                Console.WriteLine("Vali tegevus:");
                Console.WriteLine("1 - Kütuse kalkulaator");
                Console.WriteLine("2 - Isikukoodi analüüs");
                Console.WriteLine("3 - Täringumäng");
                Console.WriteLine("4 - Palgaarvestus");
                Console.WriteLine("0 - Välju");
                Console.Write("Sinu valik: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Alamfunktsioonid.KytuseKalkulaator();
                        break;

                    case "2":
                        Console.Write("Sisesta isikukood: ");
                        string isikukood = Console.ReadLine();
                        Alamfunktsioonid.HindaIsikukood(isikukood);
                        break;

                    case "3":
                        Alamfunktsioonid.TaringuMang();
                        break;

                    case "4":
                        Console.Write("Sisesta brutopalk (€): ");
                        break;

                    case "0":
                        tootan = false;
                        Console.WriteLine("Head aega!");
                        break;

                    default:
                        Console.WriteLine("Palun vali 1-4");
                        break;
                }
            }
        }
    }
}

