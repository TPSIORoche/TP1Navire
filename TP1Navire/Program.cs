using System;

namespace TP1Navire
{
    class Program
    {
        static void Main(string[] args)
        {
            //TesterInstanciations();
            //TesterEnregistreArrivee();
            //TesterRecupPosition();
            //TesterRecupPositionV2();
            //TesterEnregistrerDepart();
            TesterEstPresent();

            Console.ReadKey();
        }


        public static void TesterInstanciations()
        {
            Navire unNavire;
            unNavire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827);
            Console.WriteLine(unNavire.Affiche(unNavire));
            Navire unAutreNavire = new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500);
            Console.WriteLine(unAutreNavire.Affiche(unAutreNavire));
            unAutreNavire = new Navire("IMO8715871", "MSC PILAR");
            Console.WriteLine(unAutreNavire.Affiche(unAutreNavire));
        }

        public static void TesterEnregistreArrivee()
        {
            try
            {
                Port lavandou = new Port("lavandou");
                Navire corsaire = new Navire("IMO9427639", "corsaire");
                lavandou.EnregistrerArriver(corsaire);
                Navire vogue = new Navire("IMO9427631", "vogue");
                lavandou.EnregistrerArriver(vogue);
                Navire sunny = new Navire("IMO9427632", "sunny");
                lavandou.EnregistrerArriver(sunny);
                Navire drakar = new Navire("IMO9427633", "drakar");
                lavandou.EnregistrerArriver(drakar);
                Navire sonic = new Navire("IMO9427634", "sonic");
                lavandou.EnregistrerArriver(sonic);
                Navire trop = new Navire("IMO9427635", "trop");
                lavandou.EnregistrerArriver(trop);
                Console.WriteLine("Navire bien enregistrer dans le port");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void TesterRecupPosition()
        {
            (new Port("Toulon")).TesterRecupPosition();
        }

        public static void TesterRecupPositionV2()
        {
            (new Port("Toulon")).TesterRecupPositionV2();
        }

        public static void TesterEnregistrerDepart()
        {
            try
            {
                Port port = new Port("Toulon");
                port.EnregistrerArriver(new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827));
                port.EnregistrerArriver(new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500));
                port.EnregistrerArriver(new Navire("IMO8715871", "MSC PILAR"));
                port.EnregistrerDepart("IMO8715871");
                Console.WriteLine("Départ du navire IMO8715871 enregistré");
                port.EnregistrerDepart("IMO1111111");
                Console.WriteLine("Départ du navire IMO1111111 enregistré");
                Console.WriteLine("fin des enregistrements des départs");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void TesterEstPresent()
        {
            Port port = new Port("Toulon");
            port.EnregistrerArriver(new Navire("IMO9427639", "Copper Spirtit", "Hydrocarbures", 156827));
            port.EnregistrerArriver(new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500));
            port.EnregistrerArriver(new Navire("IMO8715871", "MSC PILAR"));
            String imo = "IMO9427639";
            Console.WriteLine("Le navire " + imo + "est présent dans le port : " + port.EstPresent(imo));
            imo = "IMO1111111";
            Console.WriteLine("Le navire " + imo + "est présent dans le port : " + port.EstPresent(imo));
        }
    }
}
