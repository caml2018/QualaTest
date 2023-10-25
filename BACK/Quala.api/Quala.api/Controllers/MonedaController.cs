using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quala.application.Queries.MonedaQ;
using Quala.domain.Entities.Dtos;
using Quala.domain.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quala.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private readonly IMonedaQuery _monedaQuery;
        private readonly IMapper _mapper;

        public MonedaController(IMonedaQuery monedaQuery, IMapper mapper)
        {
            _monedaQuery = monedaQuery;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> get(int id)
        {
            try
            {
                return Ok(new { exito = 1, mensaje = "Success", data =_mapper.Map<MonedaDto>(_monedaQuery.get(id)) });
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> getAll()
        {
            try
            {
                return Ok(new { exito = 1, mensaje = "Success", data = _mapper.Map<List<MonedaDto>>(_monedaQuery.getAll()) });
            }
            catch (System.Exception ex)
            {
                var res = ex.Message;

                return BadRequest();
            }
        }

    }
}
