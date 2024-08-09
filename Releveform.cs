using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class ReleveForm : Form
    {
        private GestionNotes gestionNotes;

        public ReleveForm(GestionNotes gestionNotes)
        {
            InitializeComponent();
            this.gestionNotes = gestionNotes;
        }

        private void btnAfficherReleve_Click(object sender, EventArgs e)
        {
            int numeroEtudiant = int.Parse(txtNumeroEtudiant.Text);
            List<Notes> releve = gestionNotes.getReleve(numeroEtudiant);

            listBoxReleve.Items.Clear();
            foreach (var note in releve)
            {
                listBoxReleve.Items.Add(note.ToString());
            }
        }
    }
}
