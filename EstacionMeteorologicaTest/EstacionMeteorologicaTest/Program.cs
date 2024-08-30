using System;
using EstacionMeteorologicaLib;

namespace EstacionMeteorologicaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var estacion = new EstacionMeteorologica();

           
            Random random = new Random();
            for (int dia = 1; dia <= 31; dia++)
            {
                for (int hora = 0; hora < 8; hora++)
                {
                    double temperatura = random.NextDouble() * 30; 
                    estacion.RegistrarTemperatura(dia, hora, temperatura);
                }
            }

            
            int diaAleatorio = random.Next(1, 32); 
            Console.WriteLine($"Mostrando temperaturas para el día {diaAleatorio}:");

            
            MostrarTemperaturas(diaAleatorio, estacion);

            
            double promedio = estacion.ObtenerTemperaturaPromedio(diaAleatorio);
            Console.WriteLine($"Temperatura promedio del día {diaAleatorio}: {Math.Round(promedio)}°C");
        }

        
        static void MostrarTemperaturas(int dia, EstacionMeteorologica estacion)
        {
            Console.WriteLine($"Temperaturas del día {dia}:");
            for (int hora = 0; hora < 8; hora++)
            {
                var registro = estacion.ObtenerRegistro(dia, hora);
                if (registro != null)
                {
                    Console.WriteLine($"Hora {registro.HoraRegistro}: {Math.Round(registro.Temperatura)}°C (Registrado por {registro.PersonaTurno.Nombre})");
                }
                else
                {
                    Console.WriteLine($"Hora {hora}: No registrado");
                }
            }
        }
    }
}
