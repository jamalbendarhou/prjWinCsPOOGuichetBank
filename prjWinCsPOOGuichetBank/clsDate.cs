using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsPOOGuichetBank
{
    public class clsDate
    {
        private int jour;
        private int mois;
        private int annee;

        public clsDate()
        {
            jour = mois = annee = 1;
        }

        public clsDate(int jour, int mois, int annee)
        {
            Jour = jour;
            Mois = mois;
            Annee = annee;
        }
        public clsDate(int jour)
        {
            Jour = jour;
            Mois = DateTime.Today.Month;
            Annee = DateTime.Today.Year;
        }
        public clsDate(int jour, int mois)
        {
            Jour = jour;
            Mois = mois;
            Annee = DateTime.Today.Year;
        }

        public int Jour
        {
            get { return jour; }
            set { jour =( value> 00 && value <32 ) ? value :1; }
        }
        public int Mois
        {
            get { return mois; }
            set { mois = (value > 00 && value < 13) ? value : 1; }
        }
        public int Annee
        {
            get { return annee; }
            set { annee = (value > 00 ) ? value : 1; }
        }

        // les methodes publiques
        public void  Ajuster(int jour, int mois, int annee)
        {
            Jour = jour;
            Mois = mois;
            Annee = annee;
        }

        public string EnChiffre()
        {
            return jour+"/"+mois+"/"+annee;
        }

        public string EnLettre()
        {
            string resultat = "";

            return resultat;


        }

    }
}
