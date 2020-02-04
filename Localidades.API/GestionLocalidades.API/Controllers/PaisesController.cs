using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionLocalidades.Data.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionLocalidades.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly IPaisesRepository _paisesRepository;

        public PaisesController(IPaisesRepository paisesRepository)
        {
            _paisesRepository = paisesRepository;
        }
        [HttpGet("ObtenerPaises")]
        public async Task<IActionResult> ObtenerPaises()
        {
            try
            {
                var paises = await _paisesRepository.ObtenerPaises();
                return Ok(paises);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}