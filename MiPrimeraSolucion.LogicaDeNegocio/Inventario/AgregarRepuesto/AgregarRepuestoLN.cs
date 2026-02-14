using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.General.Fechas;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using MiPrimeraSolucion.AccesoADatos.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.LogicaDeNegocio.General.Fechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Inventario.AgregarRepuesto
{
    public class AgregarRepuestoLN : IAgregarRepuestoLN
    {
        IAgregarRepuestoAD _agregarRepuestoAD;
        IFechasLN _fechasLN;

        public AgregarRepuestoLN()
        {
            _agregarRepuestoAD = new AgregarRepuestoAD();
            _fechasLN = new FechasLN();
        }

        public int Agregar(InventarioDto elInventarioAGuardar)
        {
            elInventarioAGuardar.Estado = true;
            elInventarioAGuardar.FechaDeRegistro = _fechasLN.ObtenerFechaActual();
            elInventarioAGuardar.FechaDeModificacion = _fechasLN.ObtenerFechaActual();
            int cantidadDeDatosAlmacenados = _agregarRepuestoAD.Agregar(elInventarioAGuardar);
            return cantidadDeDatosAlmacenados;
        }
    }
}
