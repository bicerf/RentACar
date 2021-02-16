using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class RentalDetailManager : IRentalDetailService
    {
        IRentalDetailDal _rentaldal;

        public RentalDetailManager(IRentalDetailDal rentaldal)
        {
            _rentaldal = rentaldal;
        }

        public IResult AddToSystem(RentalDetail rentalDetail)
        {
            //var result = _rentaldal.GetRentalDetails(r => r.CarId == rentalDetail.CarId && r.ReturnDate == null);
            //if (result != null)
            //{
            //    return new ErrorResult(Messages.RentalError);
            //}
            _rentaldal.Add(rentalDetail);
            return new SuccessResult(Messages.RentalAdded);
        }

       
        public IResult DeleteToSystem(RentalDetail rentalDetail)
        {
            _rentaldal.Delete(rentalDetail);
            return new SuccessResult(Messages.RentalDetailDeleted);
        }

        public IDataResult<List<RentalDetail>> GetAll()
        {
            return new SuccessDataResult<List<RentalDetail>>(_rentaldal.GetAll(), Messages.AllRentalsListed);
        }

        public IDataResult<RentalDetail> GetById(int id)
        {
            return new SuccessDataResult<RentalDetail>(_rentaldal.Get(r => r.Id == id), Messages.GetRentalDetailById);
        }
        

        public IDataResult<List<RentalDetailDto>> GetRentalDetailsDto(int carId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentaldal.GetRentalDetails(r => r.CarId == carId),Messages.ListOfRentalDetails);
        }
    
        public IResult UpdateToSystem(RentalDetail rentalDetail)
        {
            _rentaldal.Update(rentalDetail);
            return new SuccessResult(Messages.RentalDetailUpdated);
        }

        
    }
}
