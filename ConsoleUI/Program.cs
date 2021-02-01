using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            Console.WriteLine("Hepsini LİSTELE");
            Console.WriteLine("----------------");

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.Id + "-" + product.Desciption + "\n" +
                    "\tMarka:" + product.BrandId + "\t-" +
                    "\tGünlük Fiyat:" + product.DailyPrice + "TL" + "\t-" +
                    "\tAraç Rengi:" + product.ColorId + "\t-" +
                    "\tModel Yılı:" + product.ModelYear


                    );
            }
            Console.WriteLine("-----------------");

            var yeniaraba = new ProductCar
            {
                Id = 3,
                BrandId = "dacia",
                ColorId = "Kırmzı",
                Desciption = "yeni araç",
                ModelYear = 2020,
                DailyPrice = 200
            };
            Console.WriteLine("Yeni araba sisteme eklendi");
            productManager.AddToSystem(yeniaraba);
            Console.WriteLine("---------");       //Burada uyarı verdi sistem çünkü aynı ID ile atanan başka bir araç var 

            var yeniaraba1 = new ProductCar
            {
                Id = 6,
                BrandId = "dacia",
                ColorId = "Kırmzı",
                Desciption = "yeni araç",
                ModelYear = 2020,
                DailyPrice = 200
            };
            // YENİ BİR ID İLE EKLEMEYE ÇALIŞACAĞIM 
            Console.WriteLine("Yeni araba sisteme eklendi");
            productManager.AddToSystem(yeniaraba1);
            Console.WriteLine("---------");
            // EKLEDİĞİMİZ ARAÇ GERÇEKTEN EKLENMİŞ Mİ DİYE LİSTEYİ TEKRAR ÇAĞIRIYORUM!
            Console.WriteLine("Hepsini LİSTELE");
            Console.WriteLine("----------------");

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.Id + "-" + product.Desciption + "\n" +
                    "\tMarka:" + product.BrandId + "\t-" +
                    "\tGünlük Fiyat:" + product.DailyPrice + "TL" + "\t-" +
                    "\tAraç Rengi:" + product.ColorId + "\t-" +
                    "\tModel Yılı:" + product.ModelYear


                    );
            }
            Console.WriteLine("-----------------");  //DACIA ARTIK LİSTEDE GÖZÜKÜYOR!!!1


            var guncelmerco = new ProductCar
            {
                Id = 5,
                BrandId = "Mercedes",
                ColorId = "Kırmzı",
                Desciption = "yeni araç",
                ModelYear = 2020,
                DailyPrice = 3000
            };
            Console.WriteLine("Mercedes güncellendi");
            productManager.UpdateToSystem(guncelmerco);

            Console.WriteLine("-----------------------------");

            //GÜNCELLEME SONRASI TEKRAR TÜM LİSTEYİ ÇAĞIRALIM

            Console.WriteLine("Hepsini LİSTELE");
            Console.WriteLine("----------------");

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.Id + "-" + product.Desciption + "\n" +
                    "\tMarka:" + product.BrandId + "\t-" +
                    "\tGünlük Fiyat:" + product.DailyPrice + "TL" + "\t-" +
                    "\tAraç Rengi:" + product.ColorId + "\t-" +
                    "\tModel Yılı:" + product.ModelYear


                    );
            }
            Console.WriteLine("-----------------"); //LİSTEDE MERCEDES YENİ FİYATI İLE BİZİ KARŞILIYOR


            Console.WriteLine("DENEME"); //ALT KISIMDA İSE MODEL VERİP ARAÇLARI LİSTELİYORUM


            foreach (var product in productManager.GetByModelYear(2020))
            {
                Console.WriteLine(product.ModelYear +" Model " +product.BrandId);
            }
            Console.WriteLine("-----------------");


            foreach (var product in productManager.GetByModelYear(2018))
            {
                Console.WriteLine(product.ModelYear + " Model " + product.BrandId);
            }


        }
    }
}
