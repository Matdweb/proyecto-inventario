using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EliminarRepuesto
{
    public interface IEliminarRepuestoLN
    {
        bool Eliminar(int idRepuestoAEliminar);
    }
}
