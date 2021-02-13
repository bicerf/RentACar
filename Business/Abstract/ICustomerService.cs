using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();

        IDataResult<Customer> GetById(int id);
        IResult AddToSystem(Customer customer);
        IResult DeleteToSystem(Customer customer);
        IResult UpdateToSystem(Customer customer);
    }
}
