using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_PortSerie
{
    public partial class FenetrePrincipale : Form
    {
        private SerialPort portALire;
        private SerialPort portAEcrire;
        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void FenetrePrincipale_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.Items.AddRange(ports);
            cmbPortEcriture.Items.AddRange(ports);
            if (ports.Length > 1)
            {
                cmbPortEcriture.SelectedIndex = 1;
            }
            else if (ports.Length > 0)
            {
                cmbPortEcriture.SelectedIndex = 0;
            }
            if (ports.Length > 0)
            {
                cmbPorts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("pas de port serie detecté sur cet ordi");
                bOuvrirFermer.Enabled = false;
            }
        }

        private void bOuvrirFermer_Click(object sender, EventArgs e)
        {
            if (portALire != null && portALire.IsOpen)
            {
                portALire.Close();
                bOuvrirFermer.Text = "ouvrir le port";
                cmbPorts.Enabled = true;
            }
            else
            {
                if (cmbPorts.SelectedItem != null)
                {
                    string selectedPort = cmbPorts.SelectedItem.ToString();
                    //initialisation des ports
                    portALire = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                    portALire.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                    try
                    {
                        portALire.Open();
                        bOuvrirFermer.Text = "fermer le port";
                        cmbPorts.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"erreur lors de l'ouverture du port : {ex.Message}", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = portALire.ReadLine();

                this.Invoke((MethodInvoker)delegate //invoke pour mettre à jour l'interface graphique depuis un thread secondaire
                {
                    tbSortie.AppendText($"Donnée reçue sur {portALire.PortName}: {data}" + Environment.NewLine);

                    tbSortie.SelectionStart = tbSortie.Text.Length;
                    tbSortie.ScrollToCaret();
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (portALire != null && portALire.IsOpen)
            {
                portALire.Close();   
            }
            portAEcrire?.Close();
        }

        private void cmbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (portALire != null && portALire.IsOpen)
                return;

            string selectedPort = cmbPorts.SelectedItem.ToString();
            try
            {
                using (SerialPort testPort = new SerialPort(selectedPort))//creation de port temp pour tester l'etat
                {
                    testPort.Open();
                    testPort.Close(); 

                    lblStatus.Text = "Statut : Disponible";
                    lblStatus.ForeColor = Color.Green;
                    bOuvrirFermer.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                // acces refusé donc port deja ouvert par autre chose
                lblStatus.Text = "Statut :Occupé ";
                lblStatus.ForeColor = Color.Red;
                bOuvrirFermer.Enabled = false;
            }
            catch (Exception)
            {
                //autre erreur
                lblStatus.Text = "Statut : inconnu/inutilisable";
                lblStatus.ForeColor = Color.Orange;
                bOuvrirFermer.Enabled = false;
            }
        }

        private void bSendGps_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();

                if (portAEcrire != null && portAEcrire.IsOpen)
                {
                    portAEcrire.Close();
                }

                bSendGps.Text = "demarrer l'envoi GPS";
                cmbPortEcriture.Enabled = true;
                tbSortie.AppendText("------ Envoi GPS arrêté ------" + Environment.NewLine);
            }
            else
            {

                if (cmbPortEcriture.SelectedItem != null)
                {
                    string selectedWritePort = cmbPortEcriture.SelectedItem.ToString();

                    // verif si port d'ecriture different du port de lecture
                    if (cmbPorts.SelectedItem != null && selectedWritePort == cmbPorts.SelectedItem.ToString())
                    {
                        MessageBox.Show("veuillez choisir un port d'écriture différent du port de lecture", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        portAEcrire = new SerialPort(selectedWritePort, 9600, Parity.None, 8, StopBits.One);
                        portAEcrire.Open();

                        timer1.Start();

                        bSendGps.Text = "arrêter l'envoi GPS";
                        cmbPortEcriture.Enabled = false;
                        tbSortie.AppendText($"==> début de l'envoi sur {selectedWritePort}..." + Environment.NewLine);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"erreur lors de l'ouverture du port d'écriture : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (portAEcrire != null && portAEcrire.IsOpen)
            {
                try
                {
                    DateTime utcNow = DateTime.UtcNow;
                    string formattedTime = utcNow.ToString("HHmmss");

                    //Trame prof
                    string nmeaMessage = "$GPGGA," + formattedTime + ",5037.2947,N,00535.2579,E,1,10,0.8,100.0,M,45.0,M,,*6A";

                    portAEcrire.WriteLine(nmeaMessage);


                   tbSortie.AppendText($"Donnée envoyée par {portAEcrire.PortName}" + Environment.NewLine);
                    tbSortie.SelectionStart = tbSortie.Text.Length;
                    tbSortie.ScrollToCaret();
                }
                catch (Exception ex)
                {
                    timer1.Stop();
                    MessageBox.Show($"Erreur d'écriture : {ex.Message}");
                }
            }
        }
    }

}

