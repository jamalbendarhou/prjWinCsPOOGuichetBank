using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsPOOGuichetBank
{
    public class clsCompte
    {
        private string vNumero;
        private string vType;
        private clsDate vDateO;
        private string vStatut;
        private decimal vSolde;

        public clsCompte(string numero, string type, clsDate dateOuverture, string statut, decimal solde)
        {
            vNumero =numero;
            Type = type;
            vDateO = dateOuverture;  
            Statut = statut;    
            vSolde = solde;  
        }

        public clsCompte(string numero, string type, int jour, int mois, int annee, string statut, decimal solde)
        {
            vNumero = numero;
            vType = type;
            vDateO = new clsDate(jour, mois, annee);
            Statut = statut;
            vSolde = solde;
        }
        public clsCompte()
        {
            vNumero = vType = vStatut = "Pas defini";
            vDateO = new clsDate();
            vSolde = 0;
        }

        public string Numero
        {
            get => vNumero;
   
        }

        public string Type
        {
            get => vType;
            set
            {
                vType = value;  
            }
        }

        public clsDate DateOuverture
        {
            get => vDateO;

        }

        public string Statut
        {
            get => vStatut;
            set
            {
                vStatut = value;    
            }
        }

        public Decimal Solde
        {
            get => vSolde;
           
        }

        public void Ouvrir(string numero, string type)
        {
            vNumero = numero;
            vType = type;
            vDateO = new clsDate(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            vStatut = "actif";
            vSolde = 0;

            
        }

        public bool Deposer(decimal montant)
        {
            if (montant >= 2 && montant <= 20000)
            {
                vSolde += montant;
                return true;
            } else { return false; }    
        }

        /// <summary>
        /// retourne : 0 pour succes, 1 pour minimum, 2 pour maximum, -1 pour multiple de 20 , -2 pour fond insuffisant
        /// </summary>
        public int Retirer(decimal montant)
        {
            if (montant < 20) { return 1; } 
            else if (montant > 500 ) { return 2; }
            else if ( (montant % 20) != 0 ) { return -1; }
            else if ( montant > vSolde) { return -2; }
            else
            {
                vSolde -= montant;
                return 0;   
            }
           
        }

        public string Consulter()
        {
            string info = "Numero : " + vNumero + " \n Type : " + vType + " \nDate Ouverture : " +
                vDateO.EnChiffre() + " \nStatut : " + vStatut + " \nSolde : " + vSolde;
            return info;
        }

        public void Fermer()
        {
            vStatut = "fermer";
        }
    }
}