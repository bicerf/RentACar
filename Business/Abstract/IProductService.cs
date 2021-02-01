using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<ProductCar> GetAll();
        List<ProductCar> GetByModelYear(int id);
        ProductCar GetById(int id);
        void AddToSystem(ProductCar product);
        void DeleteToSystem(ProductCar product);
        void UpdateToSystem(ProductCar product);
    }
}
