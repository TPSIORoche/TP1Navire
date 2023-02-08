using System;
using System.Collections.Generic;
using System.Text;

namespace TP1Navire
{
    class Port
    {
        private string nom;
        private int nbNavireMax;
        private List<Navire> navires;

        public Port(string nom)
        {
            this.nom = nom;
            this.nbNavireMax = 5;
            this.navires = new List<Navire>();
        }

        public void EnregistrerArriver(Navire navire)
        {
            if (!(this.nbNavireMax == this.navires.Count))
            {
                this.navires.Add(navire);
            }
            else
            {
                throw new Exception("Ajout impossible,le port est complet");
            }
        }

        public void EnregistrerDepart(String imo)
        {
            if (this.EstPresent(imo))
            {
                this.navires.RemoveAt(RecupPosition(imo));
            }
            else
            {
                throw new Exception($"Impossible d'enregistrer le départ du navire {imo}, il n'est pas dans le port");
            }
        }

        public bool EstPresent(String imo)
        {
            for (int i = 0; i < this.navires.Count; i++)
            {
                if (imo == this.navires[i].Imo)
                {
                    return true;
                }
            }
            return false;
        }

        public int RecupPosition(String imo)
        {
            if (this.EstPresent(imo))
            {
                for (int i = 0; i < this.navires.Count; i++)
                {
                    if (imo == this.navires[i].Imo)
                    {
                        return i;
                    }
                }
            }
            //throw new Exception("IMO, n'est pas valide");
            return -1;
        }

        public int RecupPosition(Navire navire)
        {
            if (this.navires.Contains(navire))
            //{
            //    for (int i = 0; i < this.navires.Count - 1; ++i)
            //    {
            //        if (this.navires[i]. == this.navires[i].Imo)
            //        {
            //            return i;
            //        }
            //    }
            //}
            {
                return RecupPosition(navire.Imo);
            }
            //throw new Exception("Le navire n'est pas valide");
            return -1;
        }

        public void TesterRecupPosition()
        {
            this.EnregistrerArriver(new Navire("IMO9427639","Copper Spirit","Hydrocarbures",156827));
            this.EnregistrerArriver(new Navire("IMO9839272","MSC Isabella","Porte-conteneurs",197500));
            this.EnregistrerArriver(new Navire("IMO8715871","MSC PILAR"));
            String imo = "IMO9427639";
            Console.WriteLine("Indice du navire " + imo + " dans la collection : " + this.RecupPosition(imo));
            imo = "IMO8715871";
            Console.WriteLine("Indice du navire " + imo + " dans la collection : " + this.RecupPosition(imo));
            imo = "IMO1111111";
            Console.WriteLine("Indice du navire " + imo + " dans la collection : " + this.RecupPosition(imo));
        }

        public void TesterRecupPositionV2()
        {
            Navire navire = new Navire("IMO9427639", "Copper Spirtit", "Hydrocarbures", 156827);
            this.EnregistrerArriver(navire);
            this.EnregistrerArriver(new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500));
            this.EnregistrerArriver(new Navire("IMO8715871","MSC PILAR"));
            Console.WriteLine("Indice du navire " + navire.Imo + " dans la collection : " + this.RecupPosition(navire));
            Navire unAutreNavire = new Navire("IMO8715871", "MSC PILAR");
            Console.WriteLine("Indice du navire " + unAutreNavire.Imo + " dans la collection : " + this.RecupPosition(unAutreNavire));
            unAutreNavire = new Navire("IMO8715871", "MSC PILAR", "Porte canteneurs", 52181);
            Console.WriteLine("Indice du navire " + unAutreNavire.Imo + " dans la collection : " + this.RecupPosition(unAutreNavire));
        }

        //public void TesterEnregistrerDepart(String imo)
        //{
        //    this.EnregistrerArriver(new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827));
        //    this.EnregistrerArriver(new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500));
        //    this.EnregistrerArriver(new Navire("IMO8715871", "MSC PILAR"));
        //    return Enrgis

        //}
    }
}
