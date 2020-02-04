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
    public class ProvinciasController : ControllerBase
    {
        private readonly IProvinciasRepository _provinciasRepository;

        public ProvinciasController(IProvinciasRepository provinciasRepository)
        {
            _provinciasRepository = provinciasRepository;
        }

        [HttpGet("ObtenerProvinciasPorPais/{id}")]
        public async Task<IActionResult> ObtenerProvinciasPorPais(int id)
        {
            try
            {
                var provinciasPorPais = await _provinciasRepository.ObtenerProvinciasPorPaisId(id);
                return Ok(provinciasPorPais);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}