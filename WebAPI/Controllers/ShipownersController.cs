using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipownersController : ControllerBase
    {
        IShipownerService _shipownerService;

        public ShipownersController(IShipownerService shipownerService)
        {
            _shipownerService = shipownerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _shipownerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Shipowner shipowner)
        {
            var result = _shipownerService.Add(shipowner);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Shipowner shipowner)
        {
            var result = _shipownerService.Delete(shipowner);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
