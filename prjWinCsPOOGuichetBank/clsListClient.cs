using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsPOOGuichetBank
{
    public class clsListClient
    {

        // declaration de la collection dictionary privee qui va contenir tous les clients 
        private Dictionary<string, clsClient> maListe;
        public clsListClient()
        {
            maListe = new Dictionary<string, clsClient>();
        }

        public int Nombre
        {
            get { return maListe.Count; }


        }

        public Dictionary<string, clsClient>.ValueCollection Eelements
        {
            get { return maListe.Values; }


        }

        public bool Ajouter(clsClient unClient)
        {
            if (maListe.ContainsKey(unClient.Numero) == false)
            {
                maListe.Add(unClient.Numero, unClient);
                return true;

            }
            else { return false; }


        }

        public bool Supprimer(string numero)
        {
            return maListe.Remove(numero);
        }

        public clsClient Trouver(string numero)
        {
            if (maListe.ContainsKey(numero) == true) { return maListe[numero]; }
            else { return null; }

        }

        public bool Existe(string numero)
        {
            return maListe.ContainsKey(numero);

        }

        public string Afficher()
        {
            string info = "\n Les clients de la liste \n ";
            foreach (clsClient unCl in maListe.Values)
            {
                info += "------------------\n";
                info += unCl.Afficher() + " \n";

            }
            return info;
        }
    }
}