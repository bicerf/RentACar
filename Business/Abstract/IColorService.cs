using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<ColorCar>> GetAll();
        
        IDataResult<ColorCar> GetById(int id);
        IResult AddToSystem(ColorCar color);
        IResult DeleteToSystem(ColorCar color);
        IResult UpdateToSystem(ColorCar color);
    }
}
