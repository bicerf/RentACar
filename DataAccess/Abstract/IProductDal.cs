using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<ProductCar> GetAll();
        ProductCar GetById(int id);
        List<ProductCar> GetByModelYear(int modelyear);
        void Add(ProductCar product);
        void Update(ProductCar product);
        void Delete(ProductCar product);
        

    }
}
