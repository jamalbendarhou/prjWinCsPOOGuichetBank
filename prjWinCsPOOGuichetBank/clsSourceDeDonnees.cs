using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace prjWinCsPOOGuichetBank
{
    // classe abstraite
    public static class clsSourceDeDonnees
    {
        public static clsListClient getTousLesClients()
        {
            //---------------VERSION FICHIER TEXTE ------------
            
        //    clsListClient tousClients = new clsListClient();
        //    // lire le contenu du fichier texte, remplir la liste et la retourner
        //    StreamReader monfichier = new StreamReader("databases/datClients.txt");
        //    while (monfichier.EndOfStream == false)
        //    {
        //        string num = monfichier.ReadLine();
        //        string nom = monfichier.ReadLine();
        //        string nip = monfichier.ReadLine();
        //        string stat = monfichier.ReadLine();

        //        clsClient unClient = new clsClient(num, nom, nip, stat);

        //        // a chaque fois que l'on cree un client on l'ajoute a tous les clients
        //        tousClients.Ajouter(unClient);
        //    }
        //    monfichier.Close();

        //    return tousClients;

            //-----------VERSION BASE DE DONNEE-------------


            clsListClient tousClients = new clsListClient();

            SqlConnection mycon = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sqlBank;Integrated Security=True");
            mycon.Open();

            SqlCommand mycmd = new SqlCommand("SELECT * FROM Clients", mycon);

            SqlDataReader myRder = mycmd.ExecuteReader();

            while(myRder.Read()) 
            {
                string num = myRder["Numero"].ToString();
                string nom = myRder["Nom"].ToString();
                string nip = myRder["Nip"].ToString();
                string stat = myRder["Statut"].ToString();

                clsClient unClient = new clsClient(num, nom, nip, stat);
                tousClients.Ajouter(unClient);

            }

            myRder.Close();
            mycon.Close();
            return tousClients;

        }
        

        public static clsListCompte getLesComptesDuClient(string numeroClient)
        {
            clsListCompte tousComptes  = new clsListCompte();
            StreamReader monfichier = new StreamReader("databases/datComptes.txt");
            while (monfichier.EndOfStream == false)
            {
                string num = monfichier.ReadLine() ;
                string typ = monfichier.ReadLine() ;
                int jr = Convert.ToInt32(monfichier.ReadLine());
                int ms = Convert.ToInt32(monfichier.ReadLine());
                int an = Convert.ToInt32(monfichier.ReadLine());
                string stat = monfichier.ReadLine();
                decimal sold = Convert.ToDecimal(monfichier.ReadLine());
                string numc = monfichier.ReadLine();// numero du client 

                // verifier si numero de client concorde

                if (numc == numeroClient)
                {
                    clsCompte unCpt = new clsCompte(num, typ, jr, ms, an, stat, sold);
                    tousComptes.Ajouter(unCpt);
                }
                // a chaque fois que l'on cree un client on l'ajoute a tous les clients
                
            }
            monfichier.Close();

            return tousComptes;


        }




    }
}
