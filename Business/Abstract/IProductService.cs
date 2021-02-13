using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {   
        IDataResult<List<ProductCar>> GetAll();
        IDataResult<List<ProductCar> >GetByDailyPrice(decimal min , decimal max);
        IDataResult<List<ProductCar>> GetByModelYear(decimal min, decimal max);
        IDataResult<List<ProductCar>> GetAllByBrandId(int id);
        IDataResult<List<ProductCar>> GetAllByColorId(int id);
        IDataResult<ProductCar> GetById(int id);
        IResult AddToSystem(ProductCar product);
        IResult DeleteToSystem(ProductCar product);
        IResult UpdateToSystem(ProductCar product);

        IDataResult<List<ProductDetailDto>> GetProductDetails(Expression<Func<ProductCar, bool>> filter = null);
    }
}
