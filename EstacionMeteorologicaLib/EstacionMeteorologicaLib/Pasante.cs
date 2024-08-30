namespace EstacionMeteorologicaLib
{
    public class Pasante : Persona
    {
        public int NumeroLegajo { get; set; }

        public Pasante(string nombre, int numeroLegajo) : base(nombre)
        {
            NumeroLegajo = numeroLegajo;
        }
    }
}
