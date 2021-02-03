using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // generic constraint 
    // class : referans tip 
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new() new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new() // referans tip olabilir demek
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);          // parantez içindeki kod belli başlı dallara göre listemleme işlemi yapılırken kullanılır.
        T get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);
    }
}
