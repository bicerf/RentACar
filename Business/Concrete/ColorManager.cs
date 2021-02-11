
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult AddToSystem(ColorCar color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult DeleteToSystem(ColorCar color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<ColorCar>> GetAll()
        {
            return new SuccessDataResult<List<ColorCar>>(_colorDal.GetAll(),Messages.AllColorsListed);
        }

        public IDataResult<ColorCar>GetById(int id)
        {
            return new SuccessDataResult<ColorCar>( _colorDal.Get(c => c.Id == id),Messages.GetColorById);
        }

        public IResult UpdateToSystem(ColorCar color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
