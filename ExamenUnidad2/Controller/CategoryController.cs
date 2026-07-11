using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenUnidad2.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExamenUnidad2.Controller
{
    [ApiController] 
    [Route("api/inventario")]
    public class CategoryController : ControllerBase
    {
        private readonly List<CategoryEntities> _inventario; 

        public CategoryController()
        {
            _inventario = new List<CategoryEntities>();
            _inventario.Add(new CategoryEntities{Nombre = "1", PrecioDeVenta = 2000, PrecioDeCompra = 1000, Cantidad = 4 , Inventario = 4*1000, Margen = 2000-1000, Utilidad = (2000/1000)*100 });
            _inventario.Add(new CategoryEntities{Nombre = "2", PrecioDeVenta = 2000, PrecioDeCompra = 1000, Cantidad = 5 , Inventario = 5*1000, Margen = 2000-1000, Utilidad = (2000/1000)*100});
            _inventario.Add(new CategoryEntities{Nombre = "3", PrecioDeVenta = 2000, PrecioDeCompra = 1000, Cantidad = 7 , Inventario = 7*1000, Margen = 2000-1000, Utilidad = (2000/1000)*100});
            _inventario.Add(new CategoryEntities{Nombre = "4", PrecioDeVenta = 2000, PrecioDeCompra = 1000, Cantidad = 9 , Inventario = 9*1000, Margen = 2000-1000, Utilidad = (2000/1000)*100});
            

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_inventario);
        }

        [HttpPost]//Este método responde a las peticiones POST. Es decir, cuando se envía una nueva categoría en el cuerpo de la petición (JSON). Se agrega a la lista _categories, se muestra un mensaje en la
        public IActionResult Post([FromBody]CategoryEntities category)
        {
            _inventario.Add(category);
            Console.WriteLine($"Categoria Agregada: {category.Nombre}, {category.PrecioDeCompra}, {category.PrecioDeVenta}, {category.Cantidad},");
            return Ok("Cambio Hechos");
        }



    }
}