using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSyte
{
    public partial class Form2 : Form
    {
        private Ticket _ticket;
        public Form2(Ticket ticket)
        {
            InitializeComponent();
            _ticket = ticket;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = _ticket.DisplayInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {



            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichier texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            saveFileDialog.FileName = "Facture.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Écrire le contenu du Label dans le fichier
                    System.IO.File.WriteAllText(saveFileDialog.FileName, label2.Text);
                    MessageBox.Show("Facture téléchargée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
