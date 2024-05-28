using EjemploEFCore.Services;
using EntityFramework2Example.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework2Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    

    public class ValuesController : ControllerBase
    {

        private readonly ICancionService _cancionService;
        private readonly IAutorService _autorService;
        private readonly IAlbumService _albumService; 

        public ValuesController(ICancionService cancionService, IAutorService autorService, IAlbumService albumService)
        {
            _cancionService = cancionService;
            _autorService = autorService;
            _albumService = albumService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            _albumService.AddAlbum(new Models.Album
            {
                Nombre = "Album1"
            });

            _autorService.AddAutor(new Models.Author
            {
                Nombre = "pepe gomez"
            });

           /* _cancionService.AddCancion(new Models.Cancion
            {
                Descripcion = "Asereje Ja de je",
                Duracion = new TimeSpan(0, 4, 25),
                Titulo = "Asereje"
            });*/

           /* var canciones = _cancionService.GetCancions();

            var cancion = _cancionService.GetCancion(1);

            cancion.Descripcion = "Entidad Cambiada";

            _cancionService.updateCancion(cancion);

            _cancionService.DeleteCancion(2);
*/

            _cancionService.AddCancion(new Models.Cancion
            {
                AuthorId = 1,
                AlbumId = 1,
                Descripcion = "descripcion",
                Titulo = "Titulo",
                Duracion = new TimeSpan(0, 4, 23)
            });

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
