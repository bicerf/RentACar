using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<ProductCar, DataBaseOfContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (DataBaseOfContext context = new DataBaseOfContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands
                             on p.BrandId equals b.Id
                             select new ProductDetailDto { ProductId = p.Id, BrandName = b.BrandName,DailyPrice=p.DailyPrice };
                
                return result.ToList();

                




            }
        }
    }
}
