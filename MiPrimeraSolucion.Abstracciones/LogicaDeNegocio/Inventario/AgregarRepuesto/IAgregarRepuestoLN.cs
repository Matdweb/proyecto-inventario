using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.AgregarRepuesto
{
    public interface IAgregarRepuestoLN
    {
        int Agregar(InventarioDto elInventarioAGuardar);
    }
}
