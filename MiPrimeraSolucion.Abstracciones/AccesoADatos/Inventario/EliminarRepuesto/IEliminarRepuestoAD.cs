using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EliminarRepuesto
{
    public interface IEliminarRepuestoAD
    {
        int EliminarRepuesto(int idRepuesto);
    }
}
