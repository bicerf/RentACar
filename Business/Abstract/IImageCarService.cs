using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IImageCarService
    {

        IResult Add(IFormFile file, ImagesCar images);
        IResult Update(IFormFile file, ImagesCar images);
        IResult Delete(ImagesCar images);
        IDataResult<List<ImagesCar>> GetAll();
        IDataResult<ImagesCar> Get(int id);
        IDataResult<List<ImagesCar>> GetImagesByCarId(int id);
    }
}
