using System;
using System.Collections.Generic;
using DevWebReceitas.Application.Dtos;
using DevWebReceitas.Application.Interfaces;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Services.Api.Errors;
using Microsoft.AspNetCore.Mvc;

namespace DevWebReceitas.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ReceitaController : ControllerBase
    {
        private readonly IReceitaService _service;

        public ReceitaController(IReceitaService receitaService)
        {
            _service = receitaService;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult Create([FromBody] ReceitaInsertDto item)
        {
            try
            {
                var code = _service.Create(item);
                return CreatedAtAction(nameof(Find), new { code }, item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult Update([FromBody] ReceitaDto item)
        {
            try
            {
                _service.Update(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{codigo}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult Remove(Guid codigo)
        {
            try
            {
                _service.Remove(codigo);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ReceitaDto>), 200)]
        [ProducesResponseType(500)]
        public IActionResult Find([FromQuery] ReceitaFilter filter)
        {
            try
            {
                var result = _service.List(filter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{codigo}")]
        [ProducesResponseType(typeof(ReceitaDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [Consumes("application/json")]
        public IActionResult Find(Guid codigo)
        {
            try
            {
                return Ok(_service.FindByCode(codigo));
            }
            catch (ArgumentException ex)
            {
                return NotFound(new Error(ex));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{codigoReceita}/Imagem")]
        [ProducesResponseType(typeof(ReceitaDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Imagem(Guid codigoReceita)
        {
            try
            {
                byte[] img = _service.FindImageByCode(codigoReceita);
                return File(img, "image/png");
            }
            catch (ArgumentException ex)
            {
                return NotFound(new Error(ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}