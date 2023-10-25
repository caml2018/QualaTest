using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quala.application.Commands.SucursalC;
using Quala.application.Queries.MonedaQ;
using Quala.application.Queries.SucursalQ;
using Quala.domain.Entities.Dtos;
using Quala.domain.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quala.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISucursalQuery _sucursalQuery;
        private readonly ISucursalWrite _sucursalWrite;
        public SucursalController(IMapper mapper, ISucursalQuery sucursalQuery, ISucursalWrite sucursalWrite)
        {
            _mapper = mapper;
            _sucursalQuery = sucursalQuery;
            _sucursalWrite = sucursalWrite;
        }

        [HttpGet]
        public async Task<IActionResult> get(int id)
        {
            try
            {
                return Ok(new { exito = 1, mensaje = "Success", data = _mapper.Map<SucursalDto>(_sucursalQuery.get(id)) });
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
                return Ok(new { exito = 1, mensaje = "Success", data = _mapper.Map<List<SucursalDto>>(_sucursalQuery.getAll()) });
            }
            catch (System.Exception ex)
            {
                var res = ex.Message;

                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> add(SucursalDto sucursalDto)
        {
            try
            {
                return Ok(new { exito = 1, mensaje = "success", data = this._sucursalWrite.Add(_mapper.Map<Sucursal>(sucursalDto)) });
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { exito = 0, mensaje = "Error", data = ex.Message });
            }
        }
        [HttpDelete]
        public async Task<IActionResult> delete(int id)
        {
            try
            {
                this._sucursalWrite.delete(id);
                return Ok(new { exito = 0, mensaje = "success", data =""});
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { exito = 0, mensaje = "Error", data = ex.Message });
            }
        }
        [HttpPut]
        public async Task<IActionResult> update(SucursalDto sucursalDto)
        {
            try
            {
                return Ok(this._sucursalWrite.update(_mapper.Map<Sucursal>(sucursalDto), sucursalDto.Id));
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { exito = 0, mensaje = "Error", data = ex.Message });
            }
        }
    }
}
