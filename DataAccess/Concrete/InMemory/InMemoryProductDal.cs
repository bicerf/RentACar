using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<ProductCar> _cars;

        public InMemoryProductDal() //bellekte referans aldıktan sonra çalışacak "Ctor" yapısı
        {
            _cars = new List<ProductCar> {
                new ProductCar{Id=1,BrandId="Renault",ColorId="Kırmızı",DailyPrice=500,ModelYear=2018,Desciption="Orta segment araç"},
                new ProductCar{Id=2,BrandId="Opel",ColorId="Beyaz",DailyPrice=700,ModelYear=2018,Desciption="Orta segment araç"},
                new ProductCar{Id=3,BrandId="Volkswagen",ColorId="Lacivert",DailyPrice=1000,ModelYear=2018,Desciption="Orta-Üst segment araç"},
                new ProductCar{Id=4,BrandId="Audi",ColorId="Siyah",DailyPrice=550,ModelYear=2018,Desciption="Orta segment araç"},
                new ProductCar{Id=5,BrandId="Mercedes",ColorId="Siyah",DailyPrice=2000,ModelYear=2018,Desciption="Üst segment araç"}
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

        public List<ProductCar> GetAll()
        {
            return _cars;
        }



        public ProductCar GetById(int id) => _cars.SingleOrDefault(p => p.Id == id);


        public List<ProductCar>GetByModelYear(int modelyear) => _cars.Where(p=>p.ModelYear == modelyear).ToList();



        public void Update(ProductCar product)
        {
            ProductCar productToUpdate = _cars.SingleOrDefault(p => p.Id == product.Id);

            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.Desciption = product.Desciption;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.DailyPrice = product.DailyPrice;

        }

      
    }
}
