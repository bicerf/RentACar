
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void AddToSystem(ColorCar color)
        {
            _colorDal.Add(color);
            Console.WriteLine("İlgili renk sisteme eklendi.");
        }

        public void DeleteToSystem(ColorCar color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("İlgili renk sistemden kaldırıldı.");
        }

        public List<ColorCar> GetAll()
        {
            return _colorDal.GetAll();
        }

        public ColorCar GetById(int id)
        {
            return _colorDal.Get(c => c.Id == id);
        }

        public void UpdateToSystem(ColorCar color)
        {
            _colorDal.Update(color);
            Console.WriteLine("İlgili renk sistemde güncellendi.");
        }
    }
}
