using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.General.Fechas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace MiPrimeraSolucion.LogicaDeNegocio.General.Fechas
{
    public class FechasLN : IFechasLN
    {
        public DateTime ObtenerFechaActual()
        {
            string zonaHorariaConfig = ConfigurationManager.AppSettings["ZonaHoraria"];
            int zonaHoraria = !string.IsNullOrEmpty(zonaHorariaConfig) ? int.Parse(zonaHorariaConfig) : 0;

            return DateTime.UtcNow.AddHours(zonaHoraria);
        }
    }
}