using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DomainModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DomainModels
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository() 
        {
            _dbContext = new RestaurantReservationDbContext();
            _dbSet = _dbContext.Set<TEntity>();
        }

        public int Create(TEntity obj)
        {
            _dbSet.Add(obj);
            return _dbContext.SaveChanges();
        }

        public int Update(TEntity obj)
        {
            _dbSet.Update(obj);
            return _dbContext.SaveChanges();
        }

        public int Delete(TEntity obj)
        {
            var result = _dbSet.Find(obj);

            if (result != null)
            {
                _dbSet.Remove(result);
            }
            return _dbContext.SaveChanges();
        }


        public TEntity GetFirstByWithRelated(Func<TEntity, bool> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = _dbSet.AsQueryable();

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query.FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetAllByWithRelated(Func<TEntity, bool>? predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = _dbSet.AsQueryable();

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            if (predicate == null)
                return query;

            return query.Where(predicate);

        }

        public IEnumerable<TEntity> GetAllByWithRelatedAccumulative(Func<TEntity, bool>? predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = _dbSet.AsQueryable();

            query.Include(includeProperties.ElementAt(0))

            foreach (var includeProperty in includeProperties)
            {
                
            }

        }

    }
}
