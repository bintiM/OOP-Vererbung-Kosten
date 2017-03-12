using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kosten> kostenListe = new List<Kosten>();

            Kosten kost = new Kosten();
            kost.text = "Taxifahrt";
            kost.betrag = 20m;
            kost.datum = DateTime.Now;

            kostenListe.Add(kost);

            kmPauschale kmP = new kmPauschale();
            kmP.strecke = 150;
            kmP.datum = DateTime.Now;

            kostenListe.Add(kmP);


            decimal summe = 0m;
            foreach (Kosten k in kostenListe)
            {
                Console.WriteLine(String.Format("Text: {0} am {1} mit {2} Euro", k.text, k.datum.ToShortDateString(), k.betrag));
                summe += k.betrag;
            }
            Console.WriteLine("Die Summe ist " + summe);
            Console.ReadLine();
        }
    }
}
