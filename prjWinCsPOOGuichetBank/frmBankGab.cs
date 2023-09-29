using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            if (clientcourant == null)
            {
                MessageBox.Show("Nip de client introuvable, essayer de nouveau !!", "Nip invalide");
                txtNip.Focus();
            }
            else
            {
                this.Height = 433;
                grpNip.Enabled = false;
                
            }
            
        }

        private void btnSuivantCompte_Click(object sender, EventArgs e)
        {
            this.Height = 563;
            grpCompte.Enabled = false;  
        }

        private void btnSuivantTransaction_Click(object sender, EventArgs e)
        {
            this.Height = 697;
            grpTransaction.Enabled = false; 
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
    }
}
