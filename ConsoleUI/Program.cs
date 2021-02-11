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

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
                Console.WriteLine(brand.Id);
            }

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }


            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var car in productManager.GetProductDetails().Data)
                {

                    Console.WriteLine(car.BrandName + "/" + car.ProductId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            foreach (var p in productManager.GetByModelYear(2017, 2020).Data)
            {
                Console.WriteLine(p.Descriptions);
            }

            foreach (var p in productManager.GetAll().Data)
            {
                Console.WriteLine(p.Id + "/" + p.ModelYear);
            }
            Console.WriteLine("ARAÇLAR VE GÜNLÜK FİYATLARI");
            foreach (var p in productManager.GetProductDetails().Data)
            {
                Console.WriteLine("\n" + p.ProductId + "/" + p.DailyPrice + "/" + p.BrandName);
            }

            Console.WriteLine(productManager.GetById(1).Data.ModelYear);

            Console.WriteLine(brandManager.GetById(2).Data.BrandName);
            Console.WriteLine(colorManager.GetById(1).Data.ColorName);



        }
    }
}
