using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerRepuestoPorId;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.ObtenerRepuestoPorId
{
    public class ObtenerRepuestoPorIdAD : IObtenerRepuestoPorIdAD
    {
        private Contexto _elContexto;

        public ObtenerRepuestoPorIdAD()
        {
            _elContexto = new Contexto();
        }


        public InventarioDto Obtener(int id)
        {
            InventarioDto elRepuesto = (from elInventarioEnBaseDeDatos in _elContexto.InventarioEntidad
                                        where elInventarioEnBaseDeDatos.Id == id
                                        select new InventarioDto
                                        {
                                            Id = elInventarioEnBaseDeDatos.Id,
                                            Anio = elInventarioEnBaseDeDatos.Anio,
                                            Canitdad = elInventarioEnBaseDeDatos.Cantidad,
                                            CodigoDelRepuesto = elInventarioEnBaseDeDatos.CodigoDeRepuesto,
                                            FechaDeModificacion = elInventarioEnBaseDeDatos.FechaDeModificacion,
                                            FechaDeRegistro = elInventarioEnBaseDeDatos.FechaDeRegistro,
                                            MarcaDelRepuesto = elInventarioEnBaseDeDatos.MarcaDelRepuesto,
                                            Modelo = elInventarioEnBaseDeDatos.Modelo,
                                            NombreDelRepuesto = elInventarioEnBaseDeDatos.NombreDeRepuesto,
                                            Vehiculo = elInventarioEnBaseDeDatos.Vehiculo,
                                            Estado = elInventarioEnBaseDeDatos.Estado
                                        }).FirstOrDefault();
            return elRepuesto;
        }
    }
}
