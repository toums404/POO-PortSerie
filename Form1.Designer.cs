namespace POO_PortSerie
{
    partial class FenetrePrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.bOuvrirFermer = new System.Windows.Forms.Button();
            this.tbSortie = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bSendGps = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPortEcriture = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Items.AddRange(new object[] {
            "COM1",
            "COM2"});
            this.cmbPorts.Location = new System.Drawing.Point(307, 37);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(103, 28);
            this.cmbPorts.TabIndex = 0;
            this.cmbPorts.SelectedIndexChanged += new System.EventHandler(this.cmbPorts_SelectedIndexChanged);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(8, 40);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(293, 20);
            this.lblCom.TabIndex = 1;
            this.lblCom.Text = "Veuillez choisir le port COM de réception";
            // 
            // bOuvrirFermer
            // 
            this.bOuvrirFermer.Location = new System.Drawing.Point(12, 107);
            this.bOuvrirFermer.Name = "bOuvrirFermer";
            this.bOuvrirFermer.Size = new System.Drawing.Size(103, 93);
            this.bOuvrirFermer.TabIndex = 2;
            this.bOuvrirFermer.Text = "Appuyez pour ouvrir ou fermer la connexion";
            this.bOuvrirFermer.UseVisualStyleBackColor = true;
            this.bOuvrirFermer.Click += new System.EventHandler(this.bOuvrirFermer_Click);
            // 
            // tbSortie
            // 
            this.tbSortie.Location = new System.Drawing.Point(198, 249);
            this.tbSortie.Multiline = true;
            this.tbSortie.Name = "tbSortie";
            this.tbSortie.Size = new System.Drawing.Size(331, 156);
            this.tbSortie.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 84);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Statut : inconnu";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bSendGps
            // 
            this.bSendGps.Location = new System.Drawing.Point(12, 249);
            this.bSendGps.Name = "bSendGps";
            this.bSendGps.Size = new System.Drawing.Size(164, 93);
            this.bSendGps.TabIndex = 7;
            this.bSendGps.Text = "Démarrer/arreter l\'envoi des trames gps";
            this.bSendGps.UseVisualStyleBackColor = true;
            this.bSendGps.Click += new System.EventHandler(this.bSendGps_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Veuillez choisir le port COM d\'envoi";
            // 
            // cmbPortEcriture
            // 
            this.cmbPortEcriture.FormattingEnabled = true;
            this.cmbPortEcriture.Items.AddRange(new object[] {
            "COM1",
            "COM2"});
            this.cmbPortEcriture.Location = new System.Drawing.Point(272, 212);
            this.cmbPortEcriture.Name = "cmbPortEcriture";
            this.cmbPortEcriture.Size = new System.Drawing.Size(103, 28);
            this.cmbPortEcriture.TabIndex = 5;
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSendGps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPortEcriture);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbSortie);
            this.Controls.Add(this.bOuvrirFermer);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.cmbPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Série";
            this.Load += new System.EventHandler(this.FenetrePrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Button bOuvrirFermer;
        private System.Windows.Forms.TextBox tbSortie;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bSendGps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPortEcriture;
    }
}

