using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalDetailService
    {
        IDataResult<List<RentalDetail>> GetAll();

        IDataResult<RentalDetail> GetById(int id);
        IResult AddToSystem(RentalDetail rentalDetail);
        IResult DeleteToSystem(RentalDetail rentalDetail);
        IResult UpdateToSystem(RentalDetail rentalDetail);

        IDataResult<List<RentalDetailDto>> GetRentalDetails(Expression<Func<RentalDetail, bool>> filter = null);

    }
}
