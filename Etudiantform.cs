using System;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class EtudiantForm : Form
    {
        private GestionNotes gestionNotes;

        public EtudiantForm(GestionNotes gestionNotes)
        {
            InitializeComponent();
            this.gestionNotes = gestionNotes;
        }

        private void btnAjouterEtudiant_Click(object sender, EventArgs e)
        {
            int numeroEtudiant = int.Parse(txtNumeroEtudiant.Text);
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;

            Etudiant etudiant = new Etudiant(numeroEtudiant, nom, prenom);
            gestionNotes.AjouterEtudiant(etudiant);

            MessageBox.Show("Étudiant ajouté avec succès");
        }
    }
}
