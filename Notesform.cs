using System;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class NotesForm : Form
    {
        private GestionNotes gestionNotes;

        public NotesForm(GestionNotes gestionNotes)
        {
            InitializeComponent();
            this.gestionNotes = gestionNotes;
        }

        private void btnAjouterNote_Click(object sender, EventArgs e)
        {
            int numeroEtudiant = int.Parse(txtNumeroEtudiant.Text);
            int numeroCours = int.Parse(txtNumeroCours.Text);
            float note = float.Parse(txtNote.Text);

            Notes notes = new Notes(numeroEtudiant, numeroCours, note);
            gestionNotes.AjouterNote(notes);

            MessageBox.Show("Note ajoutée avec succès");
        }
    }
}
