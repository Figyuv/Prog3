namespace PracticaLinq
{
    internal class Estudiante
    {
        public int CI;
        public string nombreEst;
        public string codCarr;
        public int semestre;

        public Estudiante(int cI, string nombreEst, string codCarr, int semestre)
        {
            CI = cI;
            this.nombreEst = nombreEst;
            this.codCarr = codCarr;
            this.semestre = semestre;
        }
    }
}