
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class:referans tip
   public interface IEntitiyRepository<T> where T:class,IEntity,new()
    {


        List<T> GetAll(Expression<Func<T,bool>>filter=null);//Filter null olabilir eğer nullsa tüm veriyi getirir.
        T Get(Expression<Func<T, bool>> filter);//Category Id gibi değerleri getirmeyi sağlar filter girmen gerekir.
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        
    }
}
