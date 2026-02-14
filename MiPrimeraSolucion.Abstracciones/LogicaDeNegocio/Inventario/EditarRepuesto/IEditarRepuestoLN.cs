using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EditarRepuesto
{
    public interface IEditarRepuestoLN
    {
        bool Editar(InventarioDto elInventarioAEditar);
    }
}
