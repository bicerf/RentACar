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
    public class RentalsController : ControllerBase
    {
        IRentalDetailService _rentaldetailService;

        public RentalsController(IRentalDetailService rentaldetailService)
        {
            _rentaldetailService = rentaldetailService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {

            var result = _rentaldetailService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _rentaldetailService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdetails")]
        public IActionResult GetRentalDetails(int carId)
        {
            var result = _rentaldetailService.GetRentalDetailsDto(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addrental")]
        public IActionResult Add(RentalDetail rental)
        {
            var result = _rentaldetailService.AddToSystem(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleterental")]
        public IActionResult Delete(RentalDetail rental)
        {
            var result = _rentaldetailService.DeleteToSystem(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updaterental")]
        public IActionResult Update(RentalDetail rental)
        {
            var result = _rentaldetailService.UpdateToSystem(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
