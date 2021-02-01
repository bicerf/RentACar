using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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

        public void AddToSystem(ProductCar product)
        {
            _productdal.Add(product);
        }

        public void DeleteToSystem(ProductCar product)
        {
            _productdal.Delete(product);
        }

        public List<ProductCar> GetAll() => _productdal.GetAll();


        public ProductCar GetById(int id) => _productdal.GetById(id);


        public List<ProductCar> GetByModelYear(int id) => _productdal.GetByModelYear(id);
       
        public void UpdateToSystem(ProductCar product)
        {
            _productdal.Update(product);
        }
    }
}
