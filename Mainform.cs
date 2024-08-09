using System;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class MainForm : Form
    {
        private GestionNotes gestionNotes;

        public MainForm()
        {
            InitializeComponent();
            gestionNotes = new GestionNotes();
        }

        private void btnEtudiant_Click(object sender, EventArgs e)
        {
            EtudiantForm etudiantForm = new EtudiantForm(gestionNotes);
            etudiantForm.ShowDialog();
        }

        private void btnCours_Click(object sender, EventArgs e)
        {
            CoursForm coursForm = new CoursForm(gestionNotes);
            coursForm.ShowDialog();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            NotesForm notesForm = new NotesForm(gestionNotes);
            notesForm.ShowDialog();
        }

        private void btnReleve_Click(object sender, EventArgs e)
        {
            ReleveForm releveForm = new ReleveForm(gestionNotes);
            releveForm.ShowDialog();
        }
    }
}
