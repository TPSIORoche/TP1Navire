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

        public void EnrgistrerArriver(Navire navire)
        {
            if (!(this.nbNavireMax == this.navires.Count- 1))
            {
                this.navires.Add(navire);
            }
            throw new Exception("Ajout impossible,le port est complet");
        }

        public void EnregistrerDepart(String imo)
        {
            if (this.EstPresent(imo))
            {
                this.navires.Remove(imo);
            }
        }

        public bool EstPresent(String imo)
        {
            for (int i = 0; i < this.navires.Count - 1;++i)
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

            }
        }
    }
}
