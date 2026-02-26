using System;
using System.Collections.Generic;

namespace Põhitõed_ja_Funktsioonid_Konstantin_Gaponenko_IKTpv25_1_TAR
{
    public class Alamfunktsioonid
    {
        // Ülesanne 1: Kütusekulu kalkulaator
        public static void KytuseKalkulaator()
        {
            Console.Write("Sisesta km: ");
            double km;
            if (!double.TryParse(Console.ReadLine(), out km))
            {
                Console.WriteLine("Viga! Sisesta number.");
                return;
            }

            Console.Write("Sisesta kulu per 100km: ");
            double kulu;
            if (!double.TryParse(Console.ReadLine(), out kulu))
            {
                Console.WriteLine("Viga! Sisesta number.");
                return;
            }

            Console.Write("Sisesta liitri hind: ");
            double hind;
            if (!double.TryParse(Console.ReadLine(), out hind))
            {
                Console.WriteLine("Viga! Sisesta number.");
                return;
            }

            double liitrid = km / 100 * kulu;
            double maksumus = liitrid * hind;

            Console.WriteLine("Kütust kulus: " + liitrid + " l");
            Console.WriteLine("Maksumus: " + maksumus + " €");
        }

        // Ülesanne 2: Isikukoodi dekooder
        public static void HindaIsikukood(string kood)
        {
            if (kood.Length != 11)
            {
                Console.WriteLine("Viga! Isikukood peab olema 11 märki.");
                return;
            }

            int esimene;
            if (!int.TryParse(kood.Substring(0, 1), out esimene))
            {
                Console.WriteLine("Viga! Esimene märk peab olema number.");
                return;
            }

            string sugu = "Tundmatu";
            if (esimene == 1 || esimene == 3 || esimene == 5)
            {
                sugu = "Mees";
            }
            else if (esimene == 2 || esimene == 4 || esimene == 6)
            {
                sugu = "Naine";
            }

            int sajand = 2000;
            if (esimene == 1 || esimene == 2)
            {
                sajand = 1800;
            }
            else if (esimene == 3 || esimene == 4)
            {
                sajand = 1900;
            }

            int aastaLõpp;
            if (!int.TryParse(kood.Substring(1, 2), out aastaLõpp))
            {
                Console.WriteLine("Viga! Sünniaasta osa ei ole number.");
                return;
            }

            int aasta = sajand + aastaLõpp;
            string kuu  = kood.Substring(3, 2);
            string paev = kood.Substring(5, 2);

            Console.WriteLine("Oled " + sugu + ", sündinud " + paev + "." + kuu + "." + aasta);
        }

        // Ülesanne 3: Täringumäng
        public static void TaringuMang()
        {
            Random rand = new Random();
            List<int> summad = new List<int>();
            int duubleid = 0;

            for (int i = 0; i < 10; i++)
            {
                int t1 = rand.Next(1, 7);
                int t2 = rand.Next(1, 7);
                int summa = t1 + t2;

                summad.Add(summa);

                if (t1 == t2)
                {
                    duubleid = duubleid + 1;
                }

                Console.WriteLine("Vise " + (i + 1) + ": [" + t1 + "] + [" + t2 + "] = " + summa);
            }

            int kogusumma = 0;
            Console.Write("Kõik summad: ");
            for (int i = 0; i < summad.Count; i++)
            {
                kogusumma = kogusumma + summad[i];
                Console.Write(summad[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Duubleid: " + duubleid);
            Console.WriteLine("Kogusumma: " + kogusumma);
        }

        // Ülesanne 4: Palgaarvestus
        public static Tuple<double, double> ArvutaPalk(double bruto)
        {
            double maksuvaba = 0;
            if (bruto < 1200)
            {
                maksuvaba = 654;
            }

            double tootus   = bruto * 0.016;
            double pension  = bruto * 0.02;
            double tulumaks = (bruto - maksuvaba) * 0.20;

            double neto = bruto - tootus - pension - tulumaks;

            Console.WriteLine("Maksuvaba tulu: " + maksuvaba + " €");
            Console.WriteLine("Netopalk: " + neto + " €");

            return Tuple.Create(maksuvaba, neto);
        }
    }
}
