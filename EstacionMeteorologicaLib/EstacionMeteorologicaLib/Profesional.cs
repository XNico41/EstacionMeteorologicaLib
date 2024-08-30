namespace EstacionMeteorologicaLib
{
    public class Profesional : Persona
    {
        public string NumeroMatricula { get; set; }

        public Profesional(string nombre, string numeroMatricula) : base(nombre)
        {
            NumeroMatricula = numeroMatricula;
        }
    }
}
