using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EditarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.General.Fechas;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EditarRepuesto;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using MiPrimeraSolucion.AccesoADatos.Inventario.EditarRepuesto;
using MiPrimeraSolucion.LogicaDeNegocio.General.Fechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Inventario.EditarRepuesto
{
    public class EditarRepuestoLN : IEditarRepuestoLN
    {
        IEditarRepuestoAD _editarRepuestoAD;
        IFechasLN _fechasLN;

        public EditarRepuestoLN()
        {
            _editarRepuestoAD = new EditarRepuestoAD();
            _fechasLN = new FechasLN();
        }

        public bool Editar(InventarioDto elInventarioAEditar)
        {
            elInventarioAEditar.FechaDeModificacion = _fechasLN.ObtenerFechaActual();
            int resultadoDeLaEdicion = _editarRepuestoAD.EditarRepuesto(elInventarioAEditar);
            return resultadoDeLaEdicion > 0;
        }
    }
}
