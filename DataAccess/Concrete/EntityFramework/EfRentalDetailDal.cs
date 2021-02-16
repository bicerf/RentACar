using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDetailDal : EfEntityRepositoryBase<RentalDetail, DataBaseOfContext>, IRentalDetailDal
    {
        

        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetail, bool>> filter = null)
        {
            using (DataBaseOfContext context = new DataBaseOfContext())
            {
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarName = b.BrandName,
                                 UserName = u.FirstName + " " + u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 CustomerName= cu.CompanyName
                             };
                return result.ToList();

            }
        }
    }
}
