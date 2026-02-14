using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EliminarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EliminarRepuesto;
using MiPrimeraSolucion.AccesoADatos.Inventario.EliminarRepuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Inventario.EliminarRepuesto
{
    public class EliminarRepuestoLN : IEliminarRepuestoLN
    {
        IEliminarRepuestoAD _eliminarRepuestoAD;

        public EliminarRepuestoLN()
        {
            _eliminarRepuestoAD = new EliminarRepuestoAD();
        }

        public bool Eliminar(int idRepuestoAEliminar)
        {
            int resultado = _eliminarRepuestoAD.EliminarRepuesto(idRepuestoAEliminar);
            return resultado > 0;
        }
    }
}
