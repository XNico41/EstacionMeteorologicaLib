using System;

namespace EstacionMeteorologicaLib
{
    public static class CalculoTemperaturas
    {
        public static double CalcularTemperaturaPromedio(RegistroTemperatura[,] registros, int dia)
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

        public static double CalcularTemperaturaPromedio(object registros, int v)
        {
            throw new NotImplementedException();
        }
    }
}
