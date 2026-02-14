using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using MiPrimeraSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.AgregarRepuesto
{
    public class AgregarRepuestoAD : IAgregarRepuestoAD
    {
        Contexto _elContexto;

        public AgregarRepuestoAD()
        {
            _elContexto = new Contexto();
        }

        public int Agregar(InventarioDto elRepuesto)
        {
            InventarioEntidad elRepuestoAGuardar = ConvertirObjetoAEntidad(elRepuesto);

            _elContexto.InventarioEntidad.Add(elRepuestoAGuardar);
            int cantidadDeDatosAlmacenados = _elContexto.SaveChanges();
            return cantidadDeDatosAlmacenados;
        }

        private InventarioEntidad ConvertirObjetoAEntidad(InventarioDto elInventarioAGuardar)
        {
            return new InventarioEntidad
            {
                Anio = elInventarioAGuardar.Anio,
                Cantidad = elInventarioAGuardar.Canitdad,
                CodigoDeRepuesto = elInventarioAGuardar.CodigoDelRepuesto,
                FechaDeModificacion = elInventarioAGuardar.FechaDeModificacion,
                FechaDeRegistro = elInventarioAGuardar.FechaDeRegistro,
                MarcaDelRepuesto = elInventarioAGuardar.MarcaDelRepuesto,
                Modelo = elInventarioAGuardar.Modelo,
                NombreDeRepuesto = elInventarioAGuardar.NombreDelRepuesto,
                Vehiculo = elInventarioAGuardar.Vehiculo,
                Estado = elInventarioAGuardar.Estado
            };
        }
    }
}
