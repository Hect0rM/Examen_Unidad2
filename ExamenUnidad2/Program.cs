var builder = WebApplication.CreateBuilder(args);//Crea un "builder", que es el objeto que se encarga de configurar todos los servicios y la aplicación.

//Add dataBase service
//Agrega el contexto de la base de datos como un servicio. Se configura para usar SQLite y se obtiene la cadena de conexión desde el archivo de configuración (la clave es "DefaultConnection").

// Add services to the containe
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();//Configura OpenAPI (Swagger) para documentar la API. Esto permite generar una interfaz web donde puedes probar las APIs.

builder.Services.AddControllers();//Agrega los controladores a la aplicación. Es decir, prepara los endpoints de la API para recibir las peticiones.

var app = builder.Build();//Construye la aplicación a partir de las configuraciones que definiste en el builder.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())//Verifica si la aplicación está en entorno de desarrollo. Si es así, se habilita la documentación de Swagger y la referencia de Scalar API.
{
    app.MapOpenApi();//Mapea la interfaz de Swagger para que puedas acceder a la documentación en desarrollo.
 //-   app.MapScalarApiReference();//Mapea la referencia API de Scalar, es decir, permite acceder a referencias para consumir la API desde otras herramientas.
}

app.UseHttpsRedirection();//Habilita redirección automática de HTTP a HTTPS, es decir, fuerza las peticiones a usar un canal seguro.

app.UseAuthorization();//Habilita la autorización, es decir, permite que las peticiones sean evaluadas según las reglas de autenticación/autorización.

app.MapControllers();//Mapea los controladores. Es decir, aquí se conectan las rutas de tus endpoints a los métodos de tus controladores.

app.Run();//Inicia la aplicación web y se queda escuchando las peticiones entrantes.

//En resumen, este archivo es el punto de partida de tu aplicación. Configura los servicios necesarios 
// (como la base de datos), agrega Swagger, y define el pipeline de la aplicación: es decir, cómo se 
// procesan las peticiones, qué rutas se exponen, y cómo se ejecuta la aplicación completa.
