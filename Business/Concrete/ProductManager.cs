using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
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
            if (product.DailyPrice>=0)
            {
                _productdal.Add(product);
                Console.WriteLine("Sisteme araç eklendi.");
            }
            else
            {
                Console.WriteLine("Araç günlük fiyatı 0'dan büyük bir değer almalı.");
            }
            
        }

        public void DeleteToSystem(ProductCar product)
        {
            _productdal.Delete(product);
            Console.WriteLine("Sistemden ilgili araç kaldırıldı.");
        }

        public List<ProductCar> GetAll()
        {
            return _productdal.GetAll();
        }

        public List<ProductCar> GetAllByBrandId(int id)
        {
            return GetAllByBrandId(id);

        }

        public List<ProductCar> GetAllByColorId(int id)
        {
            return GetAllByColorId(id);
        }

        public List<ProductCar> GetByDailyPrice(decimal min, decimal max)
        {
            return GetByDailyPrice(min, max);
        }

        public ProductCar GetById(int id)
        {
            return _productdal.Get(c => c.Id == id);
        }

        public List<ProductCar> GetByModelYear(decimal min, decimal max)
        {
            
            return _productdal.GetAll(p =>p.ModelYear>=min && p.ModelYear<=max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productdal.GetProductDetails();
        }

        public void UpdateToSystem(ProductCar product)
        {
            if (product.DailyPrice >= 0)
            {
                _productdal.Update(product);
                Console.WriteLine("İlgili araç güncellendi.");
            }
            else
            {
                Console.WriteLine("Araç günlük fiyatı 0'dan büyük bir değer almalı.Güncellenemedi.");
            }
            
        }
    }
}
