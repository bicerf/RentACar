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
    public class BrandManager : IBrandService
    {
        IBrandDal _branddal;

        public BrandManager(IBrandDal branddal)
        {
            _branddal = branddal;
        }

        public IResult AddToSystem(BrandCar brand)
        {
            if (brand.BrandName.Length>=2)
            {
                _branddal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
            }
            else
            {
                return new ErrorResult(Messages.BrandNameError);
            }
        }

        public IResult DeleteToSystem(BrandCar brand)
        {
            _branddal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<BrandCar>> GetAll()
        {
            return new SuccessDataResult<List<BrandCar>>( _branddal.GetAll(),Messages.AllBrandsListed);
            
        }

        public IDataResult<BrandCar> GetById(int id)
        {
            return new SuccessDataResult<BrandCar>( _branddal.Get(b => b.Id == id),Messages.GetBrandById);
        }

        public IResult UpdateToSystem(BrandCar brand)
        {
            if (brand.BrandName.Length>=2)
            {
                _branddal.Update(brand);
                return new SuccessResult(Messages.BrandUpdated);
            }
            else
            {
                return new ErrorResult(Messages.BrandNameError);
            }
        }
    }
}