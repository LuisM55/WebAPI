using EjemploWebAPI.Models;
using Microsoft.AspNetCore.Mvc; /*libreria necesaria para crear los controladores*/

namespace EjemploWebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductoController : ControllerBase /*los dos puntos es para decirle que herede de: */
{
    List<Producto> productos = new List<Producto>()
    {
        new Producto{ Id = 1, Nombre = "USB", Decimal = 3},
        new Producto{ Id = 2, Nombre = "Laptop", Decimal = 500},
        new Producto{ Id = 3, Nombre = "Teclado", Decimal = 20}
    };
    [HttpGet] 
    public IEnumerable<Producto> Get(){
        return productos;
    }

    [HttpGet("{id}")]
    public Producto? GetById(int id){
return productos.Where(x=>x.Id ==id).FirstOrDefault();
    }
}
