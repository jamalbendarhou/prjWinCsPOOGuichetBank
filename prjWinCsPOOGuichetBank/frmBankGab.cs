using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsPOOGuichetBank
{
    public partial class frmBankGab : Form
    {
        public frmBankGab()
        {
            InitializeComponent();
        }
        clsGuichet monGuichet;
        clsClient clientcourant;
        clsCompte comptecourant;
        private void frmBankGab_Load(object sender, EventArgs e)
        {

            monGuichet = new clsGuichet("gui1234", "BMO", "TECCART", "Actif", 200000);
            monGuichet.Clients = clsSourceDeDonnees.getTousLesClients();
            this.Height = 210;
            txtNumero.Focus();
            Afficher(false, false);

           

        }

 

        private void btnSuivantNumero_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text.Trim().ToLower();
            clientcourant = monGuichet.Clients.Trouver(numero);
            if(clientcourant == null)
            {
                MessageBox.Show("numero de client introuvable, essayer de nouveau !!", "Numero invalide");
                txtNumero.Focus();
            }
            else
            {
                this.Height = 326;
                grpNumero.Enabled = false;
                lblMessage.Text = "Bienvenue " + clientcourant.Nom;
            }
            
        }

        private void btnSuivantNip_Click(object sender, EventArgs e)
        {
            string nip = txtNip.Text.Trim();
            if (clientcourant.Nip != nip)
            {
                MessageBox.Show("Nip de client introuvable, essayer de nouveau !!", "Nip invalide");
                txtNip.Focus();
            }
            else
            {
                this.Height = 433;
                grpNip.Enabled = false;


                // on va chercher tous les comptes du client courant 

                clientcourant.Comptes = clsSourceDeDonnees.getLesComptesDuClient(clientcourant.Numero);
                foreach (clsCompte cpt in clientcourant.Comptes.Eelements)
                {
                    cboComptes.Items.Add(cpt.Type);
                    cboComptes.SelectedIndex = 0; // choisir le 1er compte par defaut 
                }

            }
            
        }

        private void btnSuivantCompte_Click(object sender, EventArgs e)
        {
            this.Height = 563;
            grpCompte.Enabled = false;  
            // trouver le compte dont le genre a ete choisi

            foreach(clsCompte cpt in clientcourant.Comptes.Eelements)
            {
                if(cboComptes.SelectedItem.ToString() == cpt.Type)
                {
                    comptecourant = cpt;
                    break;
                }
            }

        }

        private void btnSuivantTransaction_Click(object sender, EventArgs e)
        {
            
            // gestion des transactions 
            if(radDeposer.Checked == true)
            {
                decimal montant = Convert.ToDecimal(txtDeposer.Text.Trim());
                if (comptecourant.Deposer(montant) == false)
                {
                    MessageBox.Show("le montant doit etre  entre 2 et 20000 $ ", "Echec de depot");
                    txtDeposer.Focus();
                    return;
                }
               
                
            }
            if (radRetirer.Checked == true)
            {
                decimal montant = Convert.ToDecimal(txtRetirer.Text.Trim());
                int resultat = comptecourant.Retirer(montant);
                switch (resultat)
                   {
                    case 1: MessageBox.Show("le montant minimal a retirer est 20$", "Echec de Retrait");
                        txtRetirer.Focus();
                        return;
                    case 2:
                        MessageBox.Show("le montant maximal a retirer est 500$", "Echec de Retrait");
                        txtRetirer.Focus();
                        return;
                    case -1:
                        MessageBox.Show("le montant a retirer doit etre un multiple de  20", "Echec de Retrait");
                        txtRetirer.Focus();
                        return;
                    case -2:
                        MessageBox.Show("fonds insuffisants, votre solde et de  "+comptecourant.Solde+ " $", "Echec de Retrait");
                        txtRetirer.Focus();
                        return;

                }
            }
            this.Height = 697;
            grpTransaction.Enabled = false;

            lblInfoCompte.Text = comptecourant.Consulter();
        }

        private void btnTerminer_Click(object sender, EventArgs e)
        {
            this.Height = 210;
            reInitialiser();
        }

        private void reInitialiser()
        {
            grpInformation.Enabled = grpCompte.Enabled = grpNumero.Enabled = grpNip.Enabled= grpTransaction.Enabled = true;
            lblInfoCompte.Text = lblMessage.Text = "";
            txtDeposer.Text = txtNip.Text = txtNumero.Text = txtRetirer.Text = "";
            radConsulter.Checked = true;
            cboComptes.Items.Clear();
        }


        private void Afficher(bool Depot, bool Retrait)
        {
            lblDeposer.Visible = txtDeposer.Visible = Depot;
            lblRetirer.Visible = txtRetirer.Visible = Retrait;
        }

        private void radDeposer_CheckedChanged(object sender, EventArgs e)
        {
            Afficher(true, false);
            txtDeposer.Text = "";
            txtDeposer.Focus();
            
        }

        private void radRetirer_CheckedChanged(object sender, EventArgs e)
        {
            Afficher(false, true);
            txtRetirer.Text = "";
            txtRetirer.Focus(); 
        }

        private void radConsulter_CheckedChanged(object sender, EventArgs e)
        {
            Afficher(false, false);
            txtDeposer.Text = txtRetirer.Text = "";
        }

        private void grpNip_Enter(object sender, EventArgs e)
        {

        }
    }
}
