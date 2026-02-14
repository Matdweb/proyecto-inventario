using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerTodoElInventario;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerTodoElInventario;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using MiPrimeraSolucion.AccesoADatos.Inventario.ObtenerTodoElInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Inventario.ObtenerTodoElInventario
{
    public class ObtenerTodoElInventarioLN : IObtenerTodoElInventarioLN
    {
        IObtenerTodoElInventarioAD _obtenerTodoElInventarioAD;

        public ObtenerTodoElInventarioLN()
        {
            _obtenerTodoElInventarioAD = new ObtenerTodoElInventarioAD();
        }

        public List<InventarioDto> Obtener()
        {
            List<InventarioDto> laListaDelInventario = _obtenerTodoElInventarioAD.Obtener();
            //la logica con los datos obtenidos
            return laListaDelInventario;
        }
    }
}
