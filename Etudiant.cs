namespace GestionNotes
{
    public class Etudiant
    {
        public int NumeroEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Etudiant(int numeroEtudiant, string nom, string prenom)
        {
            NumeroEtudiant = numeroEtudiant;
            Nom = nom;
            Prenom = prenom;
        }

        public override string ToString()
        {
            return $"{NumeroEtudiant}: {Nom} {Prenom}";
        }
    }
}
