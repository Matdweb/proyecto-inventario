using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerTodoElInventario;
using MiPrimeraSolucion.Abstracciones.Modelos.Inventarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Inventario.ObtenerTodoElInventario
{
    public class ObtenerTodoElInventarioLN : IObtenerTodoElInventarioLN
    {
        
        public List<InventarioDto> Obtener()
        {
            List<InventarioDto> laListaDelInventario = new List<InventarioDto>();

            laListaDelInventario.Add(new InventarioDto
            {
                Id = 1,
                MarcaDelRepuesto = "Chevrolet",
                NombreDelRepuesto = "Bujias",
                Anio = 2020,
                Canitdad = 50,
            });
            laListaDelInventario.Add(new InventarioDto
            {
                Id = 2,
                MarcaDelRepuesto = "Chevrolet",
                NombreDelRepuesto = "Bujias",
                Anio = 2020,
                Canitdad = 50,
            });
            laListaDelInventario.Add(new InventarioDto
            {
                Id = 3,
                MarcaDelRepuesto = "Chevrolet",
                NombreDelRepuesto = "Bujias",
                Anio = 2020,
                Canitdad = 50,
            });
            laListaDelInventario.Add(new InventarioDto
            {
                Id = 4,
                MarcaDelRepuesto = "Chevrolet",
                NombreDelRepuesto = "Bujias",
                Anio = 2020,
                Canitdad = 50,
            });
            laListaDelInventario.Add(new InventarioDto
            {
                Id = 5,
                MarcaDelRepuesto = "Chevrolet",
                NombreDelRepuesto = "Bujias",
                Anio = 2020,
                Canitdad = 50,
            });
            laListaDelInventario.Add(new InventarioDto
            {
                Id = 6,
                MarcaDelRepuesto = "Chevrolet",
                NombreDelRepuesto = "Bujias",
                Anio = 2020,
                Canitdad = 50,
            });

            return laListaDelInventario;
        }
    }
}
