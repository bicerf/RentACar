using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T>where T : class,IEntity,new()  //bu kısımda sınırlandırma yaptık (generic constraint) --T referans tip olacak,IEntity implemete edebilmeli ve newlenebilmeli
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T , bool>>filter);
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
