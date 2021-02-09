using Business.Abstract;
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

        public void AddToSystem(BrandCar brand)
        {
            if (brand.BrandName.Length>=2)
            {
                Console.WriteLine("İlgili marka sisteme eklendi.");
            }
            else
            {
                Console.WriteLine("Girilen marka değeri min 2 karakter olmalı.");
            }
        }

        public void DeleteToSystem(BrandCar brand)
        {
            _branddal.Delete(brand);
            Console.WriteLine("İlgili marka sistemden silindi.");
        }

        public List<BrandCar> GetAll()
        {
            return _branddal.GetAll();
            
        }

        public BrandCar GetById(int id)
        {
            return _branddal.Get(b => b.Id == id);
        }

        public void UpdateToSystem(BrandCar brand)
        {
            if (brand.BrandName.Length>=2)
            {
                _branddal.Update(brand);
                Console.WriteLine("İlgili marka güncellendi.");
            }
            else
            {
                Console.WriteLine("Girilen marka değeri min 2 karakter olmalı.");
            }
        }
    }
}