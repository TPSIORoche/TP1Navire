using System;

namespace TP1Navire
{
    class Program
    {
        static void Main(string[] args)
        {
            TesterInstanciations();
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

    }
}
