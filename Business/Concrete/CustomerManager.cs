using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;

        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public IResult AddToSystem(Customer customer)
        {
            _customerdal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult DeleteToSystem(Customer customer)
        {
            _customerdal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(), Messages.AllCustomersListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerdal.Get(c => c.UserId == id), Messages.GetCustomerById);
        }

        public IResult UpdateToSystem(Customer customer)
        {
            _customerdal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
