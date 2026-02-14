using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerRepuestoPorId;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerRepuestoPorId;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using MiPrimeraSolucion.AccesoADatos.Inventario.ObtenerRepuestoPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Inventario.ObtenerRepuestoPorId
{
    public class ObtenerRepuestoPorIdLN : IObtenerRepuestoPorIdLN
    {

        IObtenerRepuestoPorIdAD _obtenerRepuestoPorIdAD;

        public ObtenerRepuestoPorIdLN()
        {
            _obtenerRepuestoPorIdAD = new ObtenerRepuestoPorIdAD();
        }

        public InventarioDto Obtener(int id)
        {
            InventarioDto elInventario = _obtenerRepuestoPorIdAD.Obtener(id);
            return elInventario;
        }
    }
}
