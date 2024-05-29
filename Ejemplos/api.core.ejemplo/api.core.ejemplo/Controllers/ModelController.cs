using api.core.ejemplo.Models;
using api.core.ejemplo.Repository;
using api.core.ejemplo.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.core.ejemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModelItemRepository _modelRepository;

        public ModelController(IModelItemRepository modelepository)
        {
            _modelRepository = modelepository;
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ModelRequest request)
        {
            var entity = new ModelItem
            {
                EsCliente = true,
                Nombre = request.Nombre
            };
            await _modelRepository.AddModelItem(entity);
            return Ok();
        }

        //PUT
        [HttpPut]
        public void Put([FromBody] ModelItem modelItem)
        {
           _modelRepository.UpdateModelITem(modelItem);
        }


        // GET api/model/1
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _modelRepository.Get(id);

            return Ok(entity);
        }
    }
}
