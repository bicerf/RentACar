using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {   
        List<ProductCar> GetAll();
        List<ProductCar> GetByDailyPrice(decimal min , decimal max);
        List<ProductCar> GetByModelYear(decimal min, decimal max);
        List<ProductCar> GetAllByBrandId(int brandId);
        List<ProductCar> GetAllByColorId(int colorId);
        ProductCar GetById(int id);
        void AddToSystem(ProductCar product);
        void DeleteToSystem(ProductCar product);
        void UpdateToSystem(ProductCar product);

        List<ProductDetailDto> GetProductDetails();
    }
}
