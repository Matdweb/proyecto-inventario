using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerTodoElInventario;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerTodoElInventario;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.ObtenerTodoElInventario
{
    public class ObtenerTodoElInventarioAD : IObtenerTodoElInventarioAD
    {
        private Contexto _elContexto;

        public ObtenerTodoElInventarioAD()
        {
            _elContexto = new Contexto();
        }

        public List<InventarioDto> Obtener()
        {
            List<InventarioDto> laListaDelInventario = (from elInventarioEnBaseDeDatos in _elContexto.InventarioEntidad
                                                                     select new InventarioDto
                                                                     {
                                                                        Id= elInventarioEnBaseDeDatos.Id,
                                                                        Anio= elInventarioEnBaseDeDatos.Anio,
                                                                        Canitdad= elInventarioEnBaseDeDatos.Cantidad,
                                                                        CodigoDelRepuesto= elInventarioEnBaseDeDatos.CodigoDeRepuesto,
                                                                        FechaDeModificacion= elInventarioEnBaseDeDatos.FechaDeModificacion,
                                                                        FechaDeRegistro= elInventarioEnBaseDeDatos.FechaDeRegistro,
                                                                        MarcaDelRepuesto= elInventarioEnBaseDeDatos.MarcaDelRepuesto,
                                                                        Modelo= elInventarioEnBaseDeDatos.Modelo,
                                                                        NombreDelRepuesto= elInventarioEnBaseDeDatos.NombreDeRepuesto,
                                                                        Vehiculo= elInventarioEnBaseDeDatos.Vehiculo,
                                                                        Estado= elInventarioEnBaseDeDatos.Estado
                                                                     }).ToList();
            return laListaDelInventario;
        }
    }
}
