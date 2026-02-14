using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.Modelos.Inventarios
{
    public class InventarioDto
    {
        public int Id { get; set; }
		[Display(Name="Código del repuesto")]
		[MinLength(4)]
		[Required]
		public string CodigoDelRepuesto { get; set; }
		[Display(Name = "Nombre del repuesto")]
		[MaxLength(15)]
		[Required]
		public string NombreDelRepuesto { get; set; }
		[Display(Name = "Marca del repuesto")]
		[MaxLength(15)]
		[Required]
		public string MarcaDelRepuesto { get; set; }
		[Display(Name = "Vehículo")]
		[MaxLength(15)]
		[Required]
		public string Vehiculo { get; set; }
		[Display(Name = "Modelo")]
		[MaxLength(15)]
		[Required]
		public string Modelo { get; set; }
		[Display(Name = "Año")]
		[Required]
		public int Anio { get; set; }
		[Display(Name = "Cantidad")]
		[Required]
		public int Canitdad { get; set; }
		[Display(Name = "Fecha de registro")]
		public DateTime FechaDeRegistro { get; set; }
		[Display(Name = "Fecha de modificación")]
		public DateTime? FechaDeModificacion { get; set; }
		[Display(Name = "Estado")]
		public bool Estado { get; set; }

    }
}
