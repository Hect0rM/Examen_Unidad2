using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenUnidad2.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamenUnidad2.DateBase
{
    public class SalesDbContext :DbContext // Definimos un contexto de base de datos, heredando de DbContext de Entity Framework
    {
        public SalesDbContext(DbContextOptions options) : base(options)// Constructor que recibe las opciones de configuración (por ejemplo, cadena de conexión) y las pasa a la clase base DbContext
        {
            
        }

        public DbSet<CategoryEntities> Categories { get; set; }// Esta propiedad define una tabla llamada Categories en la base de datos, que se corresponde con la entidad CategoryEntites
    

    }
}