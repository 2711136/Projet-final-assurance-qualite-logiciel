using System;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GestionNotes
{
    public partial class CoursForm : Form
    {
        private GestionNotes gestionNotes;

        public CoursForm(GestionNotes gestionNotes)
        {
            InitializeComponent();
            this.gestionNotes = gestionNotes;
        }

        private void btnAjouterCours_Click(object sender, EventArgs e)
        {
            int numeroCours = int.Parse(txtNumeroCours.Text);
            string code = txtCode.Text;
            string titre = txtTitre.Text;

            Cours cours = new Cours(numeroCours, code, titre);
            gestionNotes.AjouterCours(cours);

            MessageBox.Show("Cours ajouté avec succès");
        }
    }
}
