using System;
using System.Collections.Generic;

namespace EstacionMeteorologicaLib
{
    public class EstacionMeteorologica
    {
        private readonly RegistroTemperatura[,] registros;
        private readonly List<Persona> personas;

        public EstacionMeteorologica()
        {
            registros = new RegistroTemperatura[31, 8];
            personas = CargarPersonas();
        }

        private List<Persona> CargarPersonas()
        {
            var personasList = new List<Persona>();

            for (int i = 1; i <= 3; i++)
            {
                personasList.Add(new Pasante($"Pasante {i}", i));
            }

            for (int i = 1; i <= 3; i++)
            {
                personasList.Add(new Profesional($"Profesional {i}", $"M{i:D2}"));
            }

            return personasList;
        }

        public void RegistrarTemperatura(int dia, int hora, double temperatura)
        {
            int indexPersona = ((dia - 1) * 8 + hora) % personas.Count;
            Persona personaTurno = personas[indexPersona];

            DateTime fechaRegistro = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dia);
            TimeSpan horaRegistro = new TimeSpan(hora, 0, 0);

            var registro = new RegistroTemperatura(temperatura, personaTurno, fechaRegistro, horaRegistro);
            registros[dia - 1, hora] = registro;
        }

        public void VerTemperaturas(int dia)
        {
            Console.WriteLine($"Temperaturas del día {dia}:");
            for (int hora = 0; hora < 8; hora++)
            {
                var registro = registros[dia - 1, hora];
                if (registro != null)
                {
                    Console.WriteLine($"Hora {registro.HoraRegistro}: {registro.Temperatura}°C (Registrado por {registro.PersonaTurno.Nombre})");
                }
                else
                {
                    Console.WriteLine($"Hora {hora}: No registrado");
                }
            }
        }

        public RegistroTemperatura ObtenerRegistro(int dia, int hora)
        {
            return registros[dia - 1, hora];
        }

        public double ObtenerTemperaturaPromedio(int dia)
        {
            double sumaTemperaturas = 0;
            int count = 0;

            for (int hora = 0; hora < 8; hora++)
            {
                var registro = registros[dia - 1, hora];
                if (registro != null)
                {
                    sumaTemperaturas += registro.Temperatura;
                    count++;
                }
            }

            return count > 0 ? sumaTemperaturas / count : 0;
        }
    }
}
