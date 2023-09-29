using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace prjWinCsPOOGuichetBank
{
    public class clsListCompte
    {
        // declaration de la collection dictionary privee qui va contenir tous les comptes 
        private Dictionary<string, clsCompte> maListe;
        public clsListCompte()
        {
            maListe = new Dictionary<string, clsCompte>();
        }

        public int Nombre
        {
            get { return maListe.Count; }


        }

        public Dictionary<string, clsCompte>.ValueCollection  Eelements
        {
            get { return maListe.Values; }
   
            
        }

        public bool Ajouter(clsCompte unCompte)
        {
            if (maListe.ContainsKey(unCompte.Numero) == false)
            {
                maListe.Add(unCompte.Numero, unCompte);
                return true;

            }
            else { return false; }
            
            
        }

        public bool Supprimer(string numero)
        {
           return  maListe.Remove(numero);
        }

        public clsCompte Trouver(string numero)
        {
            if (maListe.ContainsKey(numero) == true) {return maListe[numero]; }
            else { return null; }
           
        }

        public bool Existe(string numero)
        {
             return maListe.ContainsKey(numero);

        }

        public string Afficher()
        {
            string info = "\n Les Comptes de la liste \n ";
            foreach (clsCompte unCpt in maListe.Values) 
            {
                info += "------------------\n";
                info += unCpt.Consulter() + " \n";
               
            }
            return info;    
        }
    }
}