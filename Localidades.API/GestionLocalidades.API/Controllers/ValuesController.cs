using System.Collections.Generic;
using System.Threading.Tasks;
using GestionLocalidades.Data.Data;
using Microsoft.AspNetCore.Mvc;

namespace GestionLocalidades.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPaisesRepository _paisesRepository;

        public ValuesController(IPaisesRepository paisesRepository)
        {
            _paisesRepository = paisesRepository;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var test = await _paisesRepository.ObtenerPaises();
            return Ok(test);
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
