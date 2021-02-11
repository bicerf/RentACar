using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<BrandCar>> GetAll();
        IDataResult<BrandCar> GetById(int id);
        IResult AddToSystem(BrandCar brand);
        IResult DeleteToSystem(BrandCar brand);
        IResult UpdateToSystem(BrandCar brand);
    }
}
