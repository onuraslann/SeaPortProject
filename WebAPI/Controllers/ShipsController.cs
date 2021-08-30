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
    public class ShipsController : ControllerBase
    {
        IShipService _shipService;

        public ShipsController(IShipService shipService)
        {
            _shipService = shipService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _shipService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("type")]

        public IActionResult GetByType(int type)
        {
            var result = _shipService.GetByShipType(type);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("dto")]

        public IActionResult GetByDto()
        {
            var result = _shipService.GetByDtos();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]

        public IActionResult Add(Ship ship)
        {
            var result = _shipService.Add(ship);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
