namespace GestionNotes
{
    public class Notes
    {
        public int NumeroEtudiant { get; set; }
        public int NumeroCours { get; set; }
        public float Note { get; set; }

        public Notes(int numeroEtudiant, int numeroCours, float note)
        {
            NumeroEtudiant = numeroEtudiant;
            NumeroCours = numeroCours;
            Note = note;
        }

        public override string ToString()
        {
            return $"Étudiant {NumeroEtudiant} - Cours {NumeroCours}: Note {Note}";
        }
    }
}
