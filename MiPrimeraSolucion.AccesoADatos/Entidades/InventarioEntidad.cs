using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Entidades
{
    [Table("INVENTARIO")]
    public class InventarioEntidad
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CODIGO_DE_REPUESTO")]
        public string CodigoDeRepuesto { get; set; }
        [Column("NOMBRE_DEL_REPUESTO")]
        public string NombreDeRepuesto { get; set; }
        [Column("MARCA_DEL_REPUESTO")]
        public string MarcaDelRepuesto { get; set; }
        [Column("VEHICULO")]
        public string Vehiculo { get; set; }
        [Column("MODELO")]
        public string Modelo { get; set; }
        [Column("ANIO")]
        public int Anio { get; set; }
        [Column("CANTIDAD")]
        public int Cantidad { get; set; }
        [Column("FECHA_DE_REGISTRO")]
        public DateTime FechaDeRegistro { get; set; }
        [Column("FECHA_DE_MODIFICACION")]
        public DateTime? FechaDeModificacion { get; set; }
        [Column("ESTADO")]
        public bool Estado { get; set; }
    }
}
