using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprehod_po_hiši
{
    internal class Program
    {
        static Soba dnevnaSoba;
        static Soba jedilnica;
        static Soba kuhinja;
        static Zunanji zadnjeDvorišče;
        static Zunanji sprednjeDvorišče;
        static Zunanji vrt;
        static Lokacija trenutnaPozicija;

        static void PremakniSe(Lokacija novaLokacija)
        {
            trenutnaPozicija = novaLokacija;
            Console.WriteLine(trenutnaPozicija.Opis());
        }
        static void Main(string[] args)
        {
            UstvariHišo();
            trenutnaPozicija = dnevnaSoba;
            PremakniSe(dnevnaSoba);
            Console.WriteLine("Kam naj grem? K=konec");
            string odg = Console.ReadLine();
            Lokacija nova = null;
            if (odg.ToUpper() == "k")
            {
                Console.WriteLine("Lep sprehod");
            }
            else
            {
                int n = int.Parse(odg);
                nova = new Lokacija(trenutnaPozicija.izhodi[n].ime);
                switch (nova.ime)
                {
                    case "dnevna soba":
                        nova = dnevnaSoba;break;
                    case "kuhinja":
                        nova = kuhinja;break;
                    case "jedilnica":
                        nova = jedilnica; break;
                    case "sprednje dvorišče":
                        nova = sprednjeDvorišče; break;
                    case "zadnje dvorišče":
                        nova = zadnjeDvorišče; break;
                    case "vrt":
                        nova = vrt; break;
                }
            }
        }
        static void UstvariHišo()
        {
            dnevnaSoba = new Soba("Dnevna soba", "starinski tepih");
            jedilnica = new Soba("Jedilnica", "lončen lonec");
            kuhinja = new Soba("Kuhinja", "srebrn pribor");
            vrt = new Zunanji("vrt", false);
            sprednjeDvorišče = new Zunanji("Sprednje dvorišče", true);
            zadnjeDvorišče = new Zunanji("Zadnje dvorišče", false);

            dnevnaSoba.izhodi = new Lokacija[2];
            dnevnaSoba.izhodi[0] = sprednjeDvorišče;
            dnevnaSoba.izhodi[1] = jedilnica;
            kuhinja.izhodi = new Lokacija[2];
            kuhinja.izhodi[0] = dnevnaSoba;
            kuhinja.izhodi[1] = zadnjeDvorišče;
            jedilnica.izhodi = new Lokacija[2];
            jedilnica.izhodi[0] = dnevnaSoba;
            jedilnica.izhodi[1] = kuhinja;
            vrt.izhodi = new Lokacija[2];
            vrt.izhodi[0] = sprednjeDvorišče;
            vrt.izhodi[1] = zadnjeDvorišče;
            sprednjeDvorišče.izhodi = new Lokacija[2];
            sprednjeDvorišče.izhodi[0] = dnevnaSoba;
            sprednjeDvorišče.izhodi[1] = vrt;
            zadnjeDvorišče.izhodi = new Lokacija[2];
            zadnjeDvorišče.izhodi[0] = vrt;
            zadnjeDvorišče.izhodi[1] = kuhinja;


        }
    }
}
