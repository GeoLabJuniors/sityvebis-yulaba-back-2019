using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repozitory
{
    internal abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        internal BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public TEntity this[object id] => GetById(id);

        public virtual TEntity Add(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        public virtual IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual TEntity Remove(object id)
        {
            return Remove(GetById(id));
        }

        public virtual TEntity Remove(TEntity entity)
        {
            Attach(entity);
            return _dbSet.Remove(entity);
        }

        public virtual TEntity Attach(TEntity entity)
        {
            _dbSet.Attach(entity);
            return entity;
        }

    }
}
