using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsPOOGuichetBank
{
    public class clsGuichet
    {
        private string vNumero;
        private string vCompagnie;
        private string vAdresse;
        private decimal vSolde;
        private string vStatut;
        private clsListClient vClients;

        public clsGuichet(string numero, string compagnie, string adresse, string statut, clsListClient clients, decimal solde)
        {
            vNumero = numero;    
            vCompagnie = compagnie;
            vAdresse = adresse;
            vStatut = statut;
            vSolde = solde;
            vClients = clients;

        }
        public clsGuichet(string numero, string compagnie, string adresse, string statut, decimal solde)
        {
            vNumero = numero;
            vCompagnie = compagnie;
            vAdresse = adresse;
            vStatut = statut;
            vSolde = solde;
            vClients = new clsListClient();

        }

        public clsGuichet()
        {
            vNumero = vCompagnie =vAdresse = vStatut = "non defini";
            vSolde = 0;
            vClients = new clsListClient();
        }

        public string Numero
        {
            get => vNumero;
          
        }

        public string Compagnie
        {
            get => vCompagnie;
            set
            {
                vCompagnie = value;
            }
        }

        public string Adresse
        {
            get => vAdresse;
            set
            {
                vAdresse = value;

            }
        }

        public Decimal Solde
        {
            get => vSolde;
          
        }

        public string Statut
        {
            get => vStatut;
           
        }

        public clsListClient Clients
        {
            get => vClients;
            set
            {
                vClients = value;   
            }
        }

        public void Ouvrir()
        {
            throw new System.NotImplementedException();
        }

        public string Afficher()
        {
            throw new System.NotImplementedException();
        }

        public void Remplir(decimal montatnt )
        {
            vSolde = montatnt;
            vStatut = "Actif";
        }
    }
}