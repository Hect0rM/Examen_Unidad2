using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamenUnidad2.Entities
{
    public class BaseEntities
    {
        public class BaseEntity
    {
        [Column("Nombre")] 
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