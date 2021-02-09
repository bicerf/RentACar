using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<BrandCar> GetAll();
        BrandCar GetById(int brandId);
        void AddToSystem(BrandCar brand);
        void DeleteToSystem(BrandCar brand);
        void UpdateToSystem(BrandCar brand);
    }
}
