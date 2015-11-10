using NetProject.Core;
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
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {

<<<<<<< HEAD
=======
<<<<<<< HEAD
<<<<<<< HEAD
        private readonly DbContext _dbContext;
        public Repository(DbContext dbContex)
        {
            _dbContext = dbContex;
=======
        private readonly NetProjectContext _dbContext;
        public Repository()
        {
            _dbContext = new NetProjectContext();
>>>>>>> dccc99685e4292ffa4d3a031e87be19b68dfbf6b
=======
>>>>>>> origin/master
        private readonly NetProjectContext _dbContext;
        public Repository()
        {
            _dbContext = new NetProjectContext();
<<<<<<< HEAD
=======
>>>>>>> parent of eae2cc6... Imlemented Castle windsor
>>>>>>> origin/master
        }

        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity) 
        {

            _dbContext.Set<TEntity>().Remove(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> criteria) 
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(criteria);
        }

        public DbSet<TEntity> GetAll() 
        {
         
            return _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> criteria) 
        {
        
            return _dbContext.Set<TEntity>().Where(criteria);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public int Count() 
        {
            return _dbContext.Set<TEntity>().Count();
        }

        public int Count(Expression<Func<TEntity, bool>> criteria) 
        {
            return _dbContext.Set<TEntity>().Count(criteria);
        }

        public bool Any(Expression<Func<TEntity, bool>> criteria) 
        {
            return _dbContext.Set<TEntity>().Any(criteria);
        }

        public int Sum(Expression<Func<TEntity, int>> criteria) 
        {
            return _dbContext.Set<TEntity>().Sum(criteria);
        }

        public decimal Sum(Expression<Func<TEntity, decimal>> criteria) 
        {
           
            return _dbContext.Set<TEntity>().Sum(criteria);
        }

      

     
    }
}
