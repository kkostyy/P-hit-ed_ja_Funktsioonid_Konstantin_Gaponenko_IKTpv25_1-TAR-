using System;
using System.Collections.Generic;
using System.Text;

namespace Põhitõed_ja_Funktsioonid_Konstantin_Gaponenko_IKTpv25_1_TAR
{
    public class Alamfunktsioonid
    {
        {
    // Ülesanne 1: Kütusekulu kalkulaator
    public static void KytuseKalkulaator()
        {
            Console.Write("Sisesta läbitud teepikkus (km): ");
            double km = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta kütusekulu 100 km kohta (liitrit): ");
            double kuluPer100 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta kütuse liitri hind (€): ");
            double hind = Convert.ToDouble(Console.ReadLine());

            double kogukulu = (km / 100) * kuluPer100;
            double maksumus = kogukulu * hind;

            Console.WriteLine($"\n--- Kütusekulu kalkulaator ---");
            Console.WriteLine($"Kütust kulus kokku: {kogukulu:F2} liitrit");
            Console.WriteLine($"Reisi maksumus: {maksumus:F2} €");
        }

        // Ülesanne 2: Isikukoodi dekooder
        public static void HindaIsikukood(string isikukood)
        {
            if (isikukood.Length != 11)
            {
                Console.WriteLine("Viga: Isikukood peab olema täpselt 11 märki pikk!");
                return;
            }

            int esimene;
            if (!int.TryParse(isikukood.Substring(0, 1), out esimene))
            {
                Console.WriteLine("Viga: Isikukoodi esimene märk peab olema number!");
                return;
            }

            string sugu;
            int sajand;

            if (esimene == 1 || esimene == 3 || esimene == 5)
            {
                sugu = "Mees";
            }
            else if (esimene == 2 || esimene == 4 || esimene == 6)
            {
                sugu = "Naine";
            }
            else
            {
                sugu = "Tundmatu";
            }

            if (esimene == 1 || esimene == 2) sajand = 1800;
            else if (esimene == 3 || esimene == 4) sajand = 1900;
            else sajand = 2000;

            string aastaKaks = isikukood.Substring(1, 2);
            string kuu = isikukood.Substring(3, 2);
            string paev = isikukood.Substring(5, 2);

            int aasta = sajand + int.Parse(aastaKaks);

            Console.WriteLine($"Oled {sugu}, sündinud {paev}.{kuu}.{aasta}");
        }

        // Ülesanne 3: Täringumäng
        public static void TaringuMang()
        {
            Random rand = new Random();
            List<int> summad = new List<int>();
            int duubleid = 0;

            Console.WriteLine("\n--- Täringumäng ---");

            for (int i = 0; i < 10; i++)
            {
                int t1 = rand.Next(1, 7);
                int t2 = rand.Next(1, 7);
                int summa = t1 + t2;
                summad.Add(summa);

                Console.WriteLine($"Vise {i + 1}: [{t1}] + [{t2}] = {summa}");

                if (t1 == t2) duubleid++;
            }

            int kogusumma = 0;
            Console.Write("\nKõik summad: ");
            foreach (int s in summad)
            {
                kogusumma += s;
                Console.Write(s + " ");
            }

            Console.WriteLine($"\nDuubleid: {duubleid} korda");
            Console.WriteLine($"Kõikide visete kogusumma: {kogusumma}");
        }
        public static void ArvutaPalk()
        {
            
        }
    }
}
