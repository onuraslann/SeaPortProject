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
    public class ShipTypesController : ControllerBase
    {
        IShipTypeService _shipTypeService;

        public ShipTypesController(IShipTypeService shipTypeService)
        {
            _shipTypeService = shipTypeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _shipTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(ShipType shipType)
        {
            var result = _shipTypeService.Add(shipType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
