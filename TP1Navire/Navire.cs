using System;
using System.Collections.Generic;
using System.Text;

namespace TP1Navire
{
    class Navire
    {
        private string imo;
        private string nom;
        private string libelleFret;
        private int qteFretMaxi;

        public Navire(string imo, string nom, string libelleFret, int qteFretMaxi)
        {
            this.imo = imo;
            this.nom = nom;
            this.libelleFret = libelleFret;
            this.qteFretMaxi = qteFretMaxi;
        }

        public Navire(string imo, string nom): this(imo, nom, "Indéfini", 0)
        {
            //this.imo = imo;
            //this.nom = nom;
            //this.libelleFret = "0";
            //this.qteFretMaxi = 0;
        }

        public string Imo { get => imo; set => imo = value; }
        public string Nom { get => nom; set => nom = value; }
        public string LibelleFret { get => libelleFret; set => libelleFret = value; }
        public int QteFretMaxi { get => qteFretMaxi; set => qteFretMaxi = value; }

        //public string Affiche(Navire navire)
        //{
        //    return ($"\nIdentification : {navire.imo}\nNom : {navire.nom}\nType de frêt : {navire.libelleFret}\nQuantité de frêt : {navire.qteFretMaxi}\n-------------------------------");
        //}

        public string Affiche(Navire navire)
        {
            return ($"{navire.imo.ToString()}\n{navire.nom.ToString()}\n{navire.libelleFret.ToString()}\n{navire.qteFretMaxi.ToString()}\n");
        }
    }
}
