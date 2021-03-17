using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }

        public IResult AddToSystem(User user)
        {
            _userdal.Add(user);
            return new SuccessResult(Messages.UserAdded);

        }

       

        public IResult DeleteToSystem(User user)
        {
            _userdal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

       

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userdal.GetAll(), Messages.AllUsersListed);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userdal.Get(u => u.Id == id), Messages.GetUserById);
        }

        public User GetByMail(string email)
        {
            return _userdal.Get(u => u.Email == email);
        }


        public List<OperationClaim> GetClaims(User user)
        {
            return _userdal.GetClaims(user);
        }


        public IResult UpdateToSystem(User user)
        {
            _userdal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        

      
    }
}
