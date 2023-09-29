using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsPOOGuichetBank
{
    public class clsClient
    {
        private string vNumero;
        private string vNom;
        private string vNip;
        private string vStatut;
        private clsListCompte vComptes;

        public clsClient()
        {
            vNumero = vNom=vNip =vStatut= "Non defini";
            vComptes = new clsListCompte();
        }

        public clsClient(string numero, string nom, string nip, string statut)
        {
            vNumero=numero;
            vNom=nom;   
            vStatut=statut; 
            vNip = nip;
            vComptes = new clsListCompte();
        }
        public clsClient(string numero, string nom, string nip, string statut, clsListCompte comptes)
        {
            vNumero = numero;
            vNom = nom;
            vStatut = statut;
            vNip = nip;
            vComptes = comptes;
        }


        public string Numero
        {
            get => vNumero;
           
        }

        public string Nom
        {
            get => vNom;
            set
            {
                vNom = value;
            }
        }

        public string Nip
        {
            get => vNip;
            set
            {
                vNip = value;
            }
        }

        public string Statut
        {
            get => vStatut;
            set
            {
                vStatut = value;
            }
        }

        public clsListCompte Comptes
        {
            get => vComptes;
            set
            {
                vComptes = value;   
            }
        }

        public void Inscrire(string numero, string nom, string nip)
        {
            vNumero = numero;
            vNom = nom;
            vStatut = "Actif";
            vNip = nip;
            vComptes = new clsListCompte();
        }

        public string Afficher()
        {
            string info = "Numero : " + vNumero + "/n Nom : " + vNom + "\n Nip : " + vNip + "\n Statut : " + vStatut + " \n Ses Compte : " + vComptes.Afficher();
            return info;    
        }
    }
}