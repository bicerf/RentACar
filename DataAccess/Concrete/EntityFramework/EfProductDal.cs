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
        public List<ProductDetailDto> GetProductDetails(Expression<Func<ProductCar, bool>> filter = null)
        {
            using (DataBaseOfContext context = new DataBaseOfContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new ProductDetailDto
                             {
                                 ProductId = c.Id,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Descriptions = c.Descriptions,
                                 ModelYear = c.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
