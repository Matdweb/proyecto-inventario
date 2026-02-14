using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerRepuestoPorId
{
    public interface IObtenerRepuestoPorIdAD
    {
        InventarioDto Obtener(int id);
    }
}
