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
            double km = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta kulu per 100km: ");
            double kulu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta liitri hind: ");
            double hind = Convert.ToDouble(Console.ReadLine());

            double liitrid = km / 100 * kulu;
            double maksumus = liitrid * hind;

            Console.WriteLine("Kütust kulus: " + liitrid + " l");
            Console.WriteLine("Maksumus: " + maksumus + " €");
        }

        // Ülesanne 2: Isikukoodi dekooder
        public static void HindaIsikukood(string kood)
        {
            // Kontrollime pikkust
            if (kood.Length != 11)
            {
                Console.WriteLine("Viga! Isikukood peab olema 11 märki.");
                return;
            }

            // Võtame esimese numbri
            int esimene = int.Parse(kood.Substring(0, 1));

            // Määrame soo
            string sugu = "Tundmatu";
            if (esimene == 1 || esimene == 3 || esimene == 5)
            {
                sugu = "Mees";
            }
            else if (esimene == 2 || esimene == 4 || esimene == 6)
            {
                sugu = "Naine";
            }

            // Määrame sajandi
            int sajand = 2000;
            if (esimene == 1 || esimene == 2)
            {
                sajand = 1800;
            }
            else if (esimene == 3 || esimene == 4)
            {
                sajand = 1900;
            }

            // Võtame sünnikuupäeva osad
            int aastaLõpp = int.Parse(kood.Substring(1, 2));
            int aasta = sajand + aastaLõpp;
            string kuu = kood.Substring(3, 2);
            string paev = kood.Substring(5, 2);

            Console.WriteLine("Oled " + sugu + ", sündinud " + paev + "." + kuu + "." + aasta);
        }

        // Ülesanne 3: Täringumäng
        public static void TaringuMang()
        {
            Random rand = new Random();
            List<int> summad = new List<int>();
            int duubleid = 0;

            // Viskame 10 korda
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

            // Arvutame kogusumma ja kuvame kõik summad
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
            // Maksuvaba tulu
            double maksuvaba = 0;
            if (bruto < 1200)
            {
                maksuvaba = 654;
            }

            // Mahaarvamised
            double tootus = bruto * 0.016;  
            double pension = bruto * 0.02;   
            double tulumaks = (bruto - maksuvaba) * 0.20;  

            // Netopalk
            double neto = bruto - tootus - pension - tulumaks;

            Console.WriteLine("Maksuvaba tulu: " + maksuvaba + " €");
            Console.WriteLine("Netopalk: " + neto + " €");

            return Tuple.Create(maksuvaba, neto);
        }
    
    }
} 
