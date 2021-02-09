using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
                Console.WriteLine(brand.Id);
            }

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

            foreach (var car in productManager.GetProductDetails())
            {
                Console.WriteLine(car.BrandName + "/" + car.ProductId);
            }
            foreach (var p in productManager.GetByModelYear(2017, 2020))
            {
                Console.WriteLine(p.Descriptions);
            }

            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.Id + "/" + p.ModelYear);
            }
            Console.WriteLine("ARAÇLAR VE GÜNLÜK FİYATLARI");
            foreach (var p in productManager.GetProductDetails())
            {
                Console.WriteLine("\n"+ p.ProductId + "/" +p.DailyPrice+ "/" +p.BrandName );
            }
        }
    }
}
