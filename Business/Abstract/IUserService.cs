using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        IDataResult<List<User>> GetAll();

        IDataResult<User> GetById(int id);
        IResult AddToSystem(User user);
        IResult DeleteToSystem(User user);
        IResult UpdateToSystem(User user);

        User GetByMail(string email);
    }
}
