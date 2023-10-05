namespace prjWinCsPOOGuichetBank
{
    partial class frmBankGab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpNumero = new System.Windows.Forms.GroupBox();
            this.btnSuivantNumero = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpNip = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSuivantNip = new System.Windows.Forms.Button();
            this.txtNip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCompte = new System.Windows.Forms.GroupBox();
            this.cboComptes = new System.Windows.Forms.ComboBox();
            this.btnSuivantCompte = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpTransaction = new System.Windows.Forms.GroupBox();
            this.lblRetirer = new System.Windows.Forms.Label();
            this.txtRetirer = new System.Windows.Forms.TextBox();
            this.radConsulter = new System.Windows.Forms.RadioButton();
            this.radRetirer = new System.Windows.Forms.RadioButton();
            this.radDeposer = new System.Windows.Forms.RadioButton();
            this.btnSuivantTransaction = new System.Windows.Forms.Button();
            this.txtDeposer = new System.Windows.Forms.TextBox();
            this.lblDeposer = new System.Windows.Forms.Label();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.lblInfoCompte = new System.Windows.Forms.Label();
            this.btnTerminer = new System.Windows.Forms.Button();
            this.grpNumero.SuspendLayout();
            this.grpNip.SuspendLayout();
            this.grpCompte.SuspendLayout();
            this.grpTransaction.SuspendLayout();
            this.grpInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANQUE DE MONTREAL ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guichet Automatique Bancaire";
            // 
            // grpNumero
            // 
            this.grpNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpNumero.Controls.Add(this.btnSuivantNumero);
            this.grpNumero.Controls.Add(this.txtNumero);
            this.grpNumero.Controls.Add(this.label3);
            this.grpNumero.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNumero.Location = new System.Drawing.Point(11, 98);
            this.grpNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNumero.Name = "grpNumero";
            this.grpNumero.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNumero.Size = new System.Drawing.Size(693, 113);
            this.grpNumero.TabIndex = 2;
            this.grpNumero.TabStop = false;
            this.grpNumero.Text = "Verification Numero Client";
            // 
            // btnSuivantNumero
            // 
            this.btnSuivantNumero.Location = new System.Drawing.Point(459, 65);
            this.btnSuivantNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuivantNumero.Name = "btnSuivantNumero";
            this.btnSuivantNumero.Size = new System.Drawing.Size(201, 37);
            this.btnSuivantNumero.TabIndex = 2;
            this.btnSuivantNumero.Text = "Suivant  >>";
            this.btnSuivantNumero.UseVisualStyleBackColor = true;
            this.btnSuivantNumero.Click += new System.EventHandler(this.btnSuivantNumero_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(323, 32);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(231, 27);
            this.txtNumero.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Entrez Votre Numero :";
            // 
            // grpNip
            // 
            this.grpNip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpNip.Controls.Add(this.lblMessage);
            this.grpNip.Controls.Add(this.btnSuivantNip);
            this.grpNip.Controls.Add(this.txtNip);
            this.grpNip.Controls.Add(this.label4);
            this.grpNip.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNip.Location = new System.Drawing.Point(12, 213);
            this.grpNip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNip.Name = "grpNip";
            this.grpNip.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNip.Size = new System.Drawing.Size(692, 137);
            this.grpNip.TabIndex = 3;
            this.grpNip.TabStop = false;
            this.grpNip.Text = "Validation Nip";
            this.grpNip.Enter += new System.EventHandler(this.grpNip_Enter);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Blue;
            this.lblMessage.Location = new System.Drawing.Point(160, 18);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(17, 19);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "x";
            // 
            // btnSuivantNip
            // 
            this.btnSuivantNip.Location = new System.Drawing.Point(453, 86);
            this.btnSuivantNip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuivantNip.Name = "btnSuivantNip";
            this.btnSuivantNip.Size = new System.Drawing.Size(207, 37);
            this.btnSuivantNip.TabIndex = 2;
            this.btnSuivantNip.Text = "Suivant  >>";
            this.btnSuivantNip.UseVisualStyleBackColor = true;
            this.btnSuivantNip.Click += new System.EventHandler(this.btnSuivantNip_Click);
            // 
            // txtNip
            // 
            this.txtNip.Location = new System.Drawing.Point(317, 44);
            this.txtNip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNip.Name = "txtNip";
            this.txtNip.PasswordChar = '*';
            this.txtNip.Size = new System.Drawing.Size(236, 27);
            this.txtNip.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Entrez Votre Nip  :";
            // 
            // grpCompte
            // 
            this.grpCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpCompte.Controls.Add(this.cboComptes);
            this.grpCompte.Controls.Add(this.btnSuivantCompte);
            this.grpCompte.Controls.Add(this.label5);
            this.grpCompte.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompte.Location = new System.Drawing.Point(12, 357);
            this.grpCompte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCompte.Name = "grpCompte";
            this.grpCompte.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCompte.Size = new System.Drawing.Size(692, 126);
            this.grpCompte.TabIndex = 4;
            this.grpCompte.TabStop = false;
            this.grpCompte.Text = "Type de compte";
            // 
            // cboComptes
            // 
            this.cboComptes.FormattingEnabled = true;
            this.cboComptes.Location = new System.Drawing.Point(327, 34);
            this.cboComptes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboComptes.Name = "cboComptes";
            this.cboComptes.Size = new System.Drawing.Size(225, 27);
            this.cboComptes.TabIndex = 3;
            // 
            // btnSuivantCompte
            // 
            this.btnSuivantCompte.Location = new System.Drawing.Point(459, 74);
            this.btnSuivantCompte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuivantCompte.Name = "btnSuivantCompte";
            this.btnSuivantCompte.Size = new System.Drawing.Size(201, 37);
            this.btnSuivantCompte.TabIndex = 2;
            this.btnSuivantCompte.Text = "Suivant  >>";
            this.btnSuivantCompte.UseVisualStyleBackColor = true;
            this.btnSuivantCompte.Click += new System.EventHandler(this.btnSuivantCompte_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choisir Votre Compte :";
            // 
            // grpTransaction
            // 
            this.grpTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpTransaction.Controls.Add(this.lblRetirer);
            this.grpTransaction.Controls.Add(this.txtRetirer);
            this.grpTransaction.Controls.Add(this.radConsulter);
            this.grpTransaction.Controls.Add(this.radRetirer);
            this.grpTransaction.Controls.Add(this.radDeposer);
            this.grpTransaction.Controls.Add(this.btnSuivantTransaction);
            this.grpTransaction.Controls.Add(this.txtDeposer);
            this.grpTransaction.Controls.Add(this.lblDeposer);
            this.grpTransaction.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTransaction.Location = new System.Drawing.Point(12, 487);
            this.grpTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTransaction.Name = "grpTransaction";
            this.grpTransaction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTransaction.Size = new System.Drawing.Size(692, 153);
            this.grpTransaction.TabIndex = 5;
            this.grpTransaction.TabStop = false;
            this.grpTransaction.Text = "Types de Transactions";
            // 
            // lblRetirer
            // 
            this.lblRetirer.AutoSize = true;
            this.lblRetirer.Location = new System.Drawing.Point(301, 63);
            this.lblRetirer.Name = "lblRetirer";
            this.lblRetirer.Size = new System.Drawing.Size(18, 19);
            this.lblRetirer.TabIndex = 7;
            this.lblRetirer.Text = "$";
            // 
            // txtRetirer
            // 
            this.txtRetirer.Location = new System.Drawing.Point(189, 59);
            this.txtRetirer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRetirer.Name = "txtRetirer";
            this.txtRetirer.Size = new System.Drawing.Size(105, 27);
            this.txtRetirer.TabIndex = 6;
            // 
            // radConsulter
            // 
            this.radConsulter.AutoSize = true;
            this.radConsulter.Checked = true;
            this.radConsulter.Location = new System.Drawing.Point(67, 89);
            this.radConsulter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radConsulter.Name = "radConsulter";
            this.radConsulter.Size = new System.Drawing.Size(104, 23);
            this.radConsulter.TabIndex = 5;
            this.radConsulter.TabStop = true;
            this.radConsulter.Text = "Consulter";
            this.radConsulter.UseVisualStyleBackColor = true;
            this.radConsulter.CheckedChanged += new System.EventHandler(this.radConsulter_CheckedChanged);
            // 
            // radRetirer
            // 
            this.radRetirer.AutoSize = true;
            this.radRetirer.Location = new System.Drawing.Point(67, 59);
            this.radRetirer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radRetirer.Name = "radRetirer";
            this.radRetirer.Size = new System.Drawing.Size(86, 23);
            this.radRetirer.TabIndex = 4;
            this.radRetirer.Text = "Retirer";
            this.radRetirer.UseVisualStyleBackColor = true;
            this.radRetirer.CheckedChanged += new System.EventHandler(this.radRetirer_CheckedChanged);
            // 
            // radDeposer
            // 
            this.radDeposer.AutoSize = true;
            this.radDeposer.Location = new System.Drawing.Point(67, 30);
            this.radDeposer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radDeposer.Name = "radDeposer";
            this.radDeposer.Size = new System.Drawing.Size(91, 23);
            this.radDeposer.TabIndex = 3;
            this.radDeposer.Text = "Deposer";
            this.radDeposer.UseVisualStyleBackColor = true;
            this.radDeposer.CheckedChanged += new System.EventHandler(this.radDeposer_CheckedChanged);
            // 
            // btnSuivantTransaction
            // 
            this.btnSuivantTransaction.Location = new System.Drawing.Point(459, 103);
            this.btnSuivantTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuivantTransaction.Name = "btnSuivantTransaction";
            this.btnSuivantTransaction.Size = new System.Drawing.Size(201, 37);
            this.btnSuivantTransaction.TabIndex = 2;
            this.btnSuivantTransaction.Text = "Suivant  >>";
            this.btnSuivantTransaction.UseVisualStyleBackColor = true;
            this.btnSuivantTransaction.Click += new System.EventHandler(this.btnSuivantTransaction_Click);
            // 
            // txtDeposer
            // 
            this.txtDeposer.Location = new System.Drawing.Point(189, 26);
            this.txtDeposer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeposer.Name = "txtDeposer";
            this.txtDeposer.Size = new System.Drawing.Size(105, 27);
            this.txtDeposer.TabIndex = 1;
            // 
            // lblDeposer
            // 
            this.lblDeposer.AutoSize = true;
            this.lblDeposer.Location = new System.Drawing.Point(301, 30);
            this.lblDeposer.Name = "lblDeposer";
            this.lblDeposer.Size = new System.Drawing.Size(18, 19);
            this.lblDeposer.TabIndex = 0;
            this.lblDeposer.Text = "$";
            // 
            // grpInformation
            // 
            this.grpInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpInformation.Controls.Add(this.lblInfoCompte);
            this.grpInformation.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformation.Location = new System.Drawing.Point(12, 645);
            this.grpInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformation.Size = new System.Drawing.Size(692, 114);
            this.grpInformation.TabIndex = 6;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Information du Compte";
            // 
            // lblInfoCompte
            // 
            this.lblInfoCompte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoCompte.ForeColor = System.Drawing.Color.Blue;
            this.lblInfoCompte.Location = new System.Drawing.Point(51, 23);
            this.lblInfoCompte.Name = "lblInfoCompte";
            this.lblInfoCompte.Size = new System.Drawing.Size(269, 75);
            this.lblInfoCompte.TabIndex = 0;
            // 
            // btnTerminer
            // 
            this.btnTerminer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminer.Location = new System.Drawing.Point(244, 770);
            this.btnTerminer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTerminer.Name = "btnTerminer";
            this.btnTerminer.Size = new System.Drawing.Size(224, 37);
            this.btnTerminer.TabIndex = 2;
            this.btnTerminer.Text = "^^ TERMINER ^^";
            this.btnTerminer.UseVisualStyleBackColor = true;
            this.btnTerminer.Click += new System.EventHandler(this.btnTerminer_Click);
            // 
            // frmBankGab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 810);
            this.Controls.Add(this.btnTerminer);
            this.Controls.Add(this.grpInformation);
            this.Controls.Add(this.grpTransaction);
            this.Controls.Add(this.grpCompte);
            this.Controls.Add(this.grpNip);
            this.Controls.Add(this.grpNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBankGab";
            this.Text = "420-POO-TT INSTITUT TECCART";
            this.Load += new System.EventHandler(this.frmBankGab_Load);
            this.grpNumero.ResumeLayout(false);
            this.grpNumero.PerformLayout();
            this.grpNip.ResumeLayout(false);
            this.grpNip.PerformLayout();
            this.grpCompte.ResumeLayout(false);
            this.grpCompte.PerformLayout();
            this.grpTransaction.ResumeLayout(false);
            this.grpTransaction.PerformLayout();
            this.grpInformation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSuivantNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox grpNip;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSuivantNip;
        private System.Windows.Forms.TextBox txtNip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpCompte;
        private System.Windows.Forms.Button btnSuivantCompte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboComptes;
        private System.Windows.Forms.GroupBox grpTransaction;
        private System.Windows.Forms.Button btnSuivantTransaction;
        private System.Windows.Forms.TextBox txtDeposer;
        private System.Windows.Forms.Label lblDeposer;
        private System.Windows.Forms.TextBox txtRetirer;
        private System.Windows.Forms.RadioButton radConsulter;
        private System.Windows.Forms.RadioButton radRetirer;
        private System.Windows.Forms.RadioButton radDeposer;
        private System.Windows.Forms.Label lblRetirer;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Button btnTerminer;
        private System.Windows.Forms.Label lblInfoCompte;
    }
}