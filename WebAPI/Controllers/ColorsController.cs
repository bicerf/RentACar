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
    public class ColorsController : ControllerBase
    {
        IColorService _colorservice;

        public ColorsController(IColorService colorservice)
        {
            _colorservice = colorservice;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {

            var result = _colorservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _colorservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addcolor")]
        public IActionResult Add(ColorCar color)
        {
            var result = _colorservice.AddToSystem(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deletecolor")]
        public IActionResult Delete(ColorCar color)
        {
            var result = _colorservice.DeleteToSystem(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updatecolor")]
        public IActionResult Update(ColorCar color)
        {
            var result = _colorservice.UpdateToSystem(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
