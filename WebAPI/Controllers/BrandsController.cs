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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandservice;

        public BrandsController(IBrandService brandservice)
        {
            _brandservice = brandservice;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {

            var result = _brandservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addbrand")]
        public IActionResult Add(BrandCar brand)
        {
            var result = _brandservice.AddToSystem(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deletebrand")]
        public IActionResult Delete(BrandCar brand)
        {
            var result = _brandservice.DeleteToSystem(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updatecar")]
        public IActionResult Update(BrandCar brand)
        {
            var result = _brandservice.UpdateToSystem(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



    }
}
