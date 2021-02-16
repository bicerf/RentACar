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
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalDetailManager rentalDetailManager = new RentalDetailManager(new EfRentalDetailDal());

            //foreach (var brand in brandManager.GetAll().Data)
            //{
            //    Console.WriteLine(brand.BrandName);
            //    Console.WriteLine(brand.Id);
            //}

            //foreach (var color in colorManager.GetAll().Data)
            //{
            //    Console.WriteLine(color.ColorName);
            //}


            //var result = productManager.GetProductDetails();
            //if (result.Success == true)
            //{
            //    foreach (var car in productManager.GetProductDetails().Data)
            //    {

            //        Console.WriteLine(car.BrandName + "/" + car.ProductId);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            foreach (var p in productManager.GetByModelYear(2020, 2021).Data)
            {
                Console.WriteLine(p.Id);
            }


            //foreach (var p in productManager.GetAll().Data)
            //{
            //    Console.WriteLine(p.Id + "/" + p.ModelYear);
            //}
            //Console.WriteLine("ARAÇLAR VE GÜNLÜK FİYATLARI");
            //foreach (var p in productManager.GetProductDetails().Data)
            //{
            //    Console.WriteLine("\n" + p.ProductId + "/" + p.DailyPrice + "/" + p.BrandName);
            //}



            //Console.WriteLine(productManager.GetById(1).Data.ModelYear);

            //Console.WriteLine(brandManager.GetById(2).Data.BrandName);
            //Console.WriteLine(colorManager.GetById(1).Data.ColorName);

            //var resultAddUser = userManager.AddToSystem(new User
            //{
            //    FirstName = "Furkan",
            //    LastName = "Biçer",
            //    Email = "furkan@hotmail.com",
            //    Passwords = "123456"

            //}
            //);
            //Console.WriteLine(resultAddUser.Message);
            Console.WriteLine("Kullanıcı ekleme");
            //var User2 = userManager.AddToSystem(new User { FirstName = "Aybike", LastName = "Şahin", Email = "aybike@gmail.com", Passwords = "12345" });
            //Console.WriteLine(User2.Message);

            //var User2 = userManager.AddToSystem(new User { FirstName = "kadir", LastName = "kale", Email = "asdf@gmail.com", Passwords = "123" });
            //Console.WriteLine(User2.Message);

            Console.WriteLine("MÜŞTERİ EKLEME VE SİLME");
            //var resultAddCustomer = customerManager.AddToSystem(new Customer {CompanyName = "HenDev",UserId=1});
            //Console.WriteLine(resultAddCustomer.Message);

            //var resultDeleteCustomer = customerManager.DeleteToSystem(new Customer { Id = 2, CompanyName = "HevDev", UserId = 1 });
            //Console.WriteLine(resultDeleteCustomer.Message);

            //var AddCustomer = customerManager.AddToSystem(new Customer {CompanyName = "Sabancı",UserId=1});
            //Console.WriteLine(AddCustomer.Message);

            //var AddCustomer = customerManager.AddToSystem(new Customer {CompanyName = "Koç",UserId=2});
            //Console.WriteLine(AddCustomer.Message);

            //var AddCustomer = customerManager.AddToSystem(new Customer {CompanyName = "Koç",UserId=3});
            //Console.WriteLine(AddCustomer.Message);

            //var AddCustomer = customerManager.AddToSystem(new Customer {CompanyName = "GM",UserId=1002});
            //Console.WriteLine(AddCustomer.Message);





            Console.WriteLine("Kiralama İşlemi Ekleme");
            var AddRental = rentalDetailManager.AddToSystem(new RentalDetail { CarId = 4, CustomerId = 1003, RentDate = DateTime.Now, ReturnDate = null });
            Console.WriteLine(AddRental.Success + AddRental.Message);

            //var resultAddRental = rentalDetailManager.AddToSystem(new RentalDetail { CarId = 4, CustomerId = 4, RentDate = DateTime.Now, ReturnDate = null });
            //Console.WriteLine(resultAddRental.Success + resultAddRental.Message);


            //var resultAddRental = rentalDetailManager.AddToSystem(new RentalDetail { CarId = 1, CustomerId = 1003, RentDate = DateTime.Now, ReturnDate = new DateTime(2021, 02, 15) });
            //Console.WriteLine(resultAddRental.Message);


            //foreach (var brand in brandManager.GetAll().Data)
            //{
            //    Console.WriteLine(brand.BrandName +"/"+ brand.Id);
            //}

            //foreach (var rental in rentalDetailManager.GetAll().Data)
            //{
            //    Console.WriteLine(rental.Id +"/"+rental.RentDate+"/"+rental.CustomerId);
            //}

            //foreach (var user in userManager.GetAll().Data)
            //{
            //    Console.WriteLine(user.FirstName+" "+user.LastName);
            //}

            //foreach (var rental in rentalDetailManager.GetRentalDetailsDto(4).Data)
            //{
            //    Console.WriteLine(rental.CarName + "/"+ rental.CustomerName +"/" +rental.RentDate + "/"+ rental.UserName);
            //}





            //var AddCar = productManager.AddToSystem(new ProductCar { BrandId = 1, ColorId = 2, Descriptions = "new.car", DailyPrice = 230, ModelYear = 2020 });
            //Console.WriteLine(AddCar.Message);

            //var AddCar = productManager.AddToSystem(new ProductCar { BrandId = 3, ColorId = 1, Descriptions = "Kaskolu araba", DailyPrice = 200, ModelYear = 2019 });
            //Console.WriteLine(AddCar.Message);

            //var AddCar2 = productManager.AddToSystem(new ProductCar { BrandId = 1, ColorId = 2, Descriptions = "Memurdan kaskosuz ", DailyPrice = 120, ModelYear = 2016 });
            //Console.WriteLine(AddCar2.Message);

            //var Addrent = rentalDetailManager.AddToSystem(new RentalDetail { CarId = 1002, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = null });
            //Console.WriteLine(Addrent.Message);


            //var Addnewrent = rentalDetailManager.AddToSystem(new RentalDetail { CarId = 2, CustomerId = 4, RentDate = DateTime.Now, ReturnDate = null });
            //Console.WriteLine(Addnewrent.Message);






        }
    }
}
