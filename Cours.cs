namespace GestionNotes
{
    public class Cours
    {
        public int NumeroCours { get; set; }
        public string Code { get; set; }
        public string Titre { get; set; }

        public Cours(int numeroCours, string code, string titre)
        {
            NumeroCours = numeroCours;
            Code = code;
            Titre = titre;
        }

        public override string ToString()
        {
            return $"{NumeroCours}: {Code} - {Titre}";
        }
    }
}
