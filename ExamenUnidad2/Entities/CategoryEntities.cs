using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenUnidad2.Entities
{
    public class CategoryEntities
    {
    [Table("inventario")] // Indica que esta clase se va a mapear a la tabla "categories" en la base de datos
    public class CategoryEntites : BaseEntities // La clase CategoryEntites hereda de BaseEntity, así comparte propiedades como ID, fechas, etc.
    {
        [Column("Nombre del Producto")] 
        public string? Nombre { get; set; } 

        [Column("Precio de Compra")] 
        public decimal PrecioDeCompra { get; set; }

        [Column("Precio de Venta")] 
        public decimal PrecioDeVenta { get; set; } 

        [Column("Utilidad")]
        public decimal Utilidad { get; set; }

        [Column("Margen")]
        public decimal Margen { get; set; }

        [Column("Inventario")] 
        public int Inventario { get; set; } 
    }
    }
}