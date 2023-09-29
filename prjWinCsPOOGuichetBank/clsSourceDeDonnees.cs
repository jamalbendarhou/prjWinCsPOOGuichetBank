using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsPOOGuichetBank
{
    // classe abstraite
    public static class clsSourceDeDonnees
    {
        public static clsListClient getTousLesClients()
        {
            clsListClient tousClients = new clsListClient();
            // lire le contenu du fichier texte, remplir la liste et la retourner
            StreamReader monfichier = new StreamReader("databases/datClients.txt");
            while (monfichier.EndOfStream == false)
            {
                string num = monfichier.ReadLine();
                string nom = monfichier.ReadLine();
                string nip = monfichier.ReadLine();
                string stat = monfichier.ReadLine();

                clsClient unClient = new clsClient(num, nom, nip, stat);

                // a chaque fois que l'on cree un client on l'ajoute a tous les clients
                tousClients.Ajouter(unClient);
            }
            monfichier.Close();

            return tousClients;
        }
    }
}
