namespace EstacionMeteorologicaLib
{
    public abstract class Persona
    {
        public string Nombre { get; set; }

        protected Persona(string nombre)
        {
            Nombre = nombre;
        }
    }
}
