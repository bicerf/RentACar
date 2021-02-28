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
    public class ImagesController : ControllerBase
    {
        IImageCarService _imageCarService;

        public ImagesController(IImageCarService imageCarService)
        {
            _imageCarService = imageCarService;
        }

        [HttpPost("uploadimage")]
        public IActionResult Add([FromForm(Name =("Image"))] IFormFile file ,[FromForm] ImagesCar images)
        {
            var result = _imageCarService.Add(file, images);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteimage")]
        public IActionResult Delete([FromForm(Name =("Id"))] int id)
        {
            var image = _imageCarService.Get(id).Data;
            var result = _imageCarService.Delete(image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updateimage")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int id)
        {
            var image = _imageCarService.Get(id).Data;
            var result = _imageCarService.Update(file,image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _imageCarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _imageCarService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
 
}
