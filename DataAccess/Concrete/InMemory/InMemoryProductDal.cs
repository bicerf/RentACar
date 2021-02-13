using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<ProductCar> _cars;

        public InMemoryProductDal() //bellekte referans aldıktan sonra çalışacak "Ctor" yapısı
        {
            _cars = new List<ProductCar> {
                new ProductCar{Id=1,BrandId=1,ColorId=1,DailyPrice=500,ModelYear=2018,Descriptions="Orta segment araç"},
                new ProductCar{Id=2,BrandId=2,ColorId=2,DailyPrice=700,ModelYear=2018,Descriptions="Orta segment araç"},
                new ProductCar{Id=3,BrandId=3,ColorId=3,DailyPrice=1000,ModelYear=2019,Descriptions="Orta-Üst segment araç"},
                new ProductCar{Id=4,BrandId=4,ColorId=4,DailyPrice=550,ModelYear=2017,Descriptions="Orta segment araç"},
                new ProductCar{Id=5,BrandId=5,ColorId=4,DailyPrice=2000,ModelYear=2020,Descriptions="Üst segment araç"}
            };
        }
        public void Add(ProductCar product)
        {
            if (_cars.SingleOrDefault(p => p.Id == product.Id) == null)
            {
                _cars.Add(product);
            }
            else
            {
                Console.WriteLine("Bu id numarası başka bir araca atılıdır." + _cars.Count + "ve önceki idler kullanılamaz!");
            }
        }

        public void Delete(ProductCar product)
        {
            ProductCar productToDelete = _cars.SingleOrDefault(p => p.Id == product.Id);
            _cars.Remove(productToDelete);
        }

        public ProductCar Get(Expression<Func<ProductCar, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductCar> GetAll()
        {
            return _cars;
        }

        public List<ProductCar> GetAll(Expression<Func<ProductCar, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public ProductCar GetById(int id) => _cars.SingleOrDefault(p => p.Id == id);


        public List<ProductCar>GetByModelYear(int modelyear) => _cars.Where(p=>p.ModelYear == modelyear).ToList();

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails(Expression<Func<ProductCar, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductCar product)
        {
            ProductCar productToUpdate = _cars.SingleOrDefault(p => p.Id == product.Id);

            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.Descriptions = product.Descriptions;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.DailyPrice = product.DailyPrice;

        }

      
    }
}
