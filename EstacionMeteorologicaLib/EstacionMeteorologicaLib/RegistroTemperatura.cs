using System;

namespace EstacionMeteorologicaLib
{
    public class RegistroTemperatura
    {
        public double Temperatura { get; set; }
        public Persona PersonaTurno { get; set; }
        public DateTime FechaRegistro { get; set; }
        public TimeSpan HoraRegistro { get; set; }

        public RegistroTemperatura(double temperatura, Persona personaTurno, DateTime fechaRegistro, TimeSpan horaRegistro)
        {
            Temperatura = temperatura;
            PersonaTurno = personaTurno;
            FechaRegistro = fechaRegistro;
            HoraRegistro = horaRegistro;
        }
    }
}
