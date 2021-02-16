using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productdal;

        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
        }

        public IResult AddToSystem(ProductCar product)
        {
            if (product.DailyPrice>=0)
            {
                _productdal.Add(product);
                return new SuccessResult(Messages.ProductAdded);
            }
            else
            {                
                return new ErrorResult(Messages.DailyPriceError );
            }
            
        }

        public IResult DeleteToSystem(ProductCar product)
        {
            _productdal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<ProductCar>> GetAll()
        {
            if (DateTime.Now.Hour == 01)
            {
                return new ErrorDataResult<List<ProductCar>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<ProductCar>>(_productdal.GetAll(),Messages.AllProductsListed);
        }

        public IDataResult<List<ProductCar>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<ProductCar>>( _productdal.GetAll(p => p.BrandId == id),Messages.ListByBrandId);

        }

        public IDataResult<List<ProductCar>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<ProductCar>>(_productdal.GetAll(p => p.ColorId == id), Messages.ListByColorId);
        }

        public IDataResult<List<ProductCar>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<ProductCar>>( _productdal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max),Messages.ListByDailyPrice);
        }

        public IDataResult<ProductCar> GetById(int id)
        {
            return new SuccessDataResult<ProductCar>( _productdal.Get(c => c.Id == id),Messages.GetId);
        }

        public IDataResult<List<ProductCar>>GetByModelYear(decimal min, decimal max)
        {

            return new SuccessDataResult<List<ProductCar>>(_productdal.GetAll(p => p.ModelYear >= min && p.ModelYear <= max), Messages.ListByModel);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails(Expression<Func<ProductCar,bool>>filter = null)
        {
            return new SuccessDataResult<List<ProductDetailDto>>( _productdal.GetProductDetails(),Messages.ListOfProductDetails);
        }

        public IResult UpdateToSystem(ProductCar product)
        {
            if (product.DailyPrice >= 0)
            {
                _productdal.Update(product);
                return new SuccessResult(Messages.ProductUpdated);
            }
            else
            {
                return new ErrorResult(Messages.DailyPriceError);
            }
            
        }
    }
}
