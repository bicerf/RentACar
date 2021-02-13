using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDetailDal:IEntityRepository<RentalDetail>
    {
        List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetail, bool>> filter = null);
    }
}
