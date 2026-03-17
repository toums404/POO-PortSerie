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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pBrowser = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbPortEcriture = new System.Windows.Forms.ComboBox();
            this.tbSortie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bOuvrirFermer = new System.Windows.Forms.Button();
            this.bSendGps = new System.Windows.Forms.Button();
            this.lblCom = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pBrowser
            // 
            this.pBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBrowser.Location = new System.Drawing.Point(0, 0);
            this.pBrowser.Name = "pBrowser";
            this.pBrowser.Size = new System.Drawing.Size(833, 652);
            this.pBrowser.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbPorts);
            this.splitContainer1.Panel1.Controls.Add(this.lblCom);
            this.splitContainer1.Panel1.Controls.Add(this.bSendGps);
            this.splitContainer1.Panel1.Controls.Add(this.lblStatus);
            this.splitContainer1.Panel1.Controls.Add(this.bOuvrirFermer);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPortEcriture);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tbSortie);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(1255, 652);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 185);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Statut : inconnu";
            // 
            // cmbPortEcriture
            // 
            this.cmbPortEcriture.FormattingEnabled = true;
            this.cmbPortEcriture.Items.AddRange(new object[] {
            "COM1",
            "COM2"});
            this.cmbPortEcriture.Location = new System.Drawing.Point(276, 313);
            this.cmbPortEcriture.Name = "cmbPortEcriture";
            this.cmbPortEcriture.Size = new System.Drawing.Size(103, 28);
            this.cmbPortEcriture.TabIndex = 5;
            // 
            // tbSortie
            // 
            this.tbSortie.Location = new System.Drawing.Point(202, 350);
            this.tbSortie.Multiline = true;
            this.tbSortie.Name = "tbSortie";
            this.tbSortie.Size = new System.Drawing.Size(212, 156);
            this.tbSortie.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Veuillez choisir le port COM d\'envoi";
            // 
            // bOuvrirFermer
            // 
            this.bOuvrirFermer.Location = new System.Drawing.Point(16, 208);
            this.bOuvrirFermer.Name = "bOuvrirFermer";
            this.bOuvrirFermer.Size = new System.Drawing.Size(103, 93);
            this.bOuvrirFermer.TabIndex = 2;
            this.bOuvrirFermer.Text = "Appuyez pour ouvrir ou fermer la connexion";
            this.bOuvrirFermer.UseVisualStyleBackColor = true;
            this.bOuvrirFermer.Click += new System.EventHandler(this.bOuvrirFermer_Click);
            // 
            // bSendGps
            // 
            this.bSendGps.Location = new System.Drawing.Point(16, 350);
            this.bSendGps.Name = "bSendGps";
            this.bSendGps.Size = new System.Drawing.Size(164, 93);
            this.bSendGps.TabIndex = 7;
            this.bSendGps.Text = "Démarrer/arreter l\'envoi des trames gps";
            this.bSendGps.UseVisualStyleBackColor = true;
            this.bSendGps.Click += new System.EventHandler(this.bSendGps_Click);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(12, 141);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(293, 20);
            this.lblCom.TabIndex = 1;
            this.lblCom.Text = "Veuillez choisir le port COM de réception";
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Items.AddRange(new object[] {
            "COM1",
            "COM2"});
            this.cmbPorts.Location = new System.Drawing.Point(311, 138);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(103, 28);
            this.cmbPorts.TabIndex = 0;
            this.cmbPorts.SelectedIndexChanged += new System.EventHandler(this.cmbPorts_SelectedIndexChanged);
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 652);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Série";
            this.Load += new System.EventHandler(this.FenetrePrincipale_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pBrowser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Button bSendGps;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button bOuvrirFermer;
        private System.Windows.Forms.ComboBox cmbPortEcriture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSortie;
    }
}

