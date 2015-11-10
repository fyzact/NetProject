using NetProject.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetProject.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void Delete(TEntity entity) ;
        TEntity Get(Expression<Func<TEntity, bool>> criteria) ;
        DbSet<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> criteria) ;
        void SaveChanges();
        int Count() ;
        int Count(Expression<Func<TEntity, bool>> criteria) ;
        bool Any(Expression<Func<TEntity, bool>> criteria) ;

        int Sum(Expression<Func<TEntity, int>> criteria) ;

        decimal Sum(Expression<Func<TEntity, decimal>> criteria) ;
    }
}
