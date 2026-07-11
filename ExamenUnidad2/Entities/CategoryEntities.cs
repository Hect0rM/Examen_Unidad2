using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenUnidad2.Entities
{
    [Table("inventario")]
    public class CategoryEntities : BaseEntities
    {
     // Indica que esta clase se va a mapear a la tabla "categories" en la base de datos
        [Column("Nombre del Producto")] 
        public string? Nombre { get; set; } 

        [Column("Precio de Compra")] 
        public int PrecioDeCompra { get; set; }

        [Column("Precio de Venta")] 
        public int PrecioDeVenta { get; set; } 

        [Column("Utilidad")]
        public int Utilidad { get; set; }

        [Column("Margen")]
        public int Margen { get; set; }

        [Column("Inventario")] 
        public int Inventario { get; set; } 

        [Column("Cantidad")] 
        public int Cantidad { get; set; } 

        
    }
    
}