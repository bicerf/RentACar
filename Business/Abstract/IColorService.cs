using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<ColorCar> GetAll();
        
        ColorCar GetById(int colorId);
        void AddToSystem(ColorCar color);
        void DeleteToSystem(ColorCar color);
        void UpdateToSystem(ColorCar color);
    }
}
