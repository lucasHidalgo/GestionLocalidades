using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionLocalidades.Data.Data;
using GestionLocalidades.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GestionLocalidades.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadesController : ControllerBase
    {
        private readonly ILocalidadesRepository _localidadesRepository;

        public LocalidadesController(ILocalidadesRepository localidadesRepository)
        {
            _localidadesRepository = localidadesRepository;
        }
        [HttpGet("ObtenerLocalidades")]
        public async Task<IActionResult> ObtenerLocalidades()
        {
            try
            {
                var localidades = await _localidadesRepository.ObtenerLocalidades();
                return Ok(localidades);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("AgregarLocalidad")]
        public async Task<IActionResult> AgregarLocalidad(Localidades localidad)
        {
            try
            {
                if (_localidadesRepository.EstaValidado(localidad))
                    return BadRequest("El nombre esta vacio");

                await _localidadesRepository.CrearLocalidad(localidad);
                return Ok(localidad);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("ObtenerLocalidadPorId/{id}")]
        public async Task<IActionResult> ObtenerLocalidadPorId(int id)
        {
            try
            {
                var localidades = await _localidadesRepository.ObtenerLocalidadPorId(id);
                return Ok(localidades);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("EditarLocalidad/{id}")]
        public async Task<IActionResult> EditarLocalidad(int id, Localidades localidad)
        {
            try
            {
                if (_localidadesRepository.EstaValidado(localidad))
                    return BadRequest("El nombre esta vacio");
                
                await _localidadesRepository.EditarLocalidad(localidad);
                return Ok("localidad editada");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

  

        [HttpDelete("BorrarLocalidad/{id}")]
        public async Task<IActionResult> BorrarLocalidad(int id)
        {
            try
            {
                await _localidadesRepository.BorrarLocalidad(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}