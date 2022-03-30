namespace PracticaLinq
{
    internal class Materia
    {
        public string CodMateria;
        public string NomMateria;
        public int Semestre;

        public Materia(string codMateria, string nomMateria, int semestre)
        {
            CodMateria = codMateria;
            NomMateria = nomMateria;
            Semestre = semestre;
        }
    }
}