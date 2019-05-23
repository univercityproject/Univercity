using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace ModelLayer
{
   public class GenericRepository<TEntity> where TEntity:class
    {
       internal DbContext _context;
       internal DbSet<TEntity> _dbset;
       public GenericRepository(DbContext context)
       {
           _context = context;
           _dbset = context.Set<TEntity>();


           string con = _context.Database.Connection.ConnectionString;
       }

       public IEnumerable<TEntity> All()
       {
           return _dbset.AsNoTracking().ToList();
       }

       public IEnumerable<TEntity> FindBy(Expression<Func<TEntity,bool>> predicat)
       {
           IEnumerable<TEntity> result = _dbset.AsNoTracking()
                                        .Where(predicat).ToList();

           return result;
       }



        public TEntity Find(Expression<Func<TEntity, bool>> predicat)
        {
            TEntity result = _dbset.AsNoTracking()
                                         .Where(predicat).FirstOrDefault();

            return result;
        }

        public TEntity FindByKey(int id)
       {
           Expression<Func<TEntity, bool>> lambda = Utilities.BuildforLambdaFindbyKey<TEntity>(id);
           return _dbset.AsNoTracking().SingleOrDefault(lambda);
       }

        public TEntity FindKey(int id)
        {
            Expression<Func<TEntity, bool>> lambda = Utilities.BuildforLambdaFindbyKey<TEntity>(id);
            return _dbset.Where(lambda).First();
        }



        public IEnumerable<TEntity> AllInclude(params Expression<Func<TEntity, object>>[] includeProperties)
       {
           return GetAllIncluding(includeProperties).ToList();
       }

       public IEnumerable<TEntity> FindByInclude (Expression<Func<TEntity, bool>> predicate,params Expression<Func<TEntity, object>>[] includeProperties)
       {
           var query = GetAllIncluding(includeProperties);
           IEnumerable<TEntity> results = query.Where(predicate).ToList();
           return results;
       }

       private IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
       {
           IQueryable<TEntity> queryable = _dbset.AsNoTracking();
           return includeProperties.Aggregate(queryable, (current, includeProperty) => current.Include(includeProperty));
       }



       public int Insert(TEntity entity)
       {
           _dbset.Add(entity);
           return _context.SaveChanges();
       }

       public int Update(TEntity entity)
       {
           try
           {
                _dbset.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
               return _context.SaveChanges();
           }
           catch (Exception ex)
           {
               return 0;


           }
          
       }

       public int Delete(int id)
       {
           TEntity entity = FindKey(id);


           _dbset.Attach(entity);
           _context.Entry(entity).State = EntityState.Deleted;
           return _context.SaveChanges();

       }



    }
}
