using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Generic Constraint -- Kısıtlama
    //Class : Referans tip
    //new'lenebilir bir class 
    public interface IEntityRepository<T> where T :class,IEntity,new()
    {
        //Expression -- DLG denilen yapılardır 
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
