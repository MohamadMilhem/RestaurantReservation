using RestaurantReservation.Db.DomainModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DomainModels
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        int Create(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        TEntity GetFirstByWithRelated(Func<TEntity, bool> predicate, params Expression<Func<TEntity, object>>[] includeProperties);
        IEnumerable<TEntity> GetAllByWithRelated(Func<TEntity, bool>? predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);

    }
}
