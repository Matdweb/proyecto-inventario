using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EditarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EditarRepuesto;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using MiPrimeraSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.EditarRepuesto
{
    public class EditarRepuestoAD : IEditarRepuestoAD
    {
        Contexto _elContexto;

        public EditarRepuestoAD()
        {
            _elContexto = new Contexto();
        }
        public int EditarRepuesto(InventarioDto elRepuestoAEditar)
        {
            InventarioEntidad repuestoEnBaseDeDatos = _elContexto.InventarioEntidad
                .Where(r => r.Id == elRepuestoAEditar.Id).FirstOrDefault();
            if (repuestoEnBaseDeDatos != null)
            {
                repuestoEnBaseDeDatos.CodigoDeRepuesto = elRepuestoAEditar.CodigoDelRepuesto;
                repuestoEnBaseDeDatos.NombreDeRepuesto = elRepuestoAEditar.NombreDelRepuesto;
                repuestoEnBaseDeDatos.MarcaDelRepuesto = elRepuestoAEditar.MarcaDelRepuesto;
                repuestoEnBaseDeDatos.Vehiculo = elRepuestoAEditar.Vehiculo;
                repuestoEnBaseDeDatos.Modelo = elRepuestoAEditar.Modelo;
                repuestoEnBaseDeDatos.Anio = elRepuestoAEditar.Anio;
                repuestoEnBaseDeDatos.Cantidad = elRepuestoAEditar.Canitdad;
                repuestoEnBaseDeDatos.FechaDeModificacion = elRepuestoAEditar.FechaDeModificacion;
                repuestoEnBaseDeDatos.Estado = elRepuestoAEditar.Estado;
                return _elContexto.SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
