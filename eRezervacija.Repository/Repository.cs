using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRezervacija.Repository
{
	public interface IRepository<TEntity>
	{
		void Add(TEntity obj);
		void Update(TEntity obj);
		void Remove(TEntity obj);
		IEnumerable<TEntity> GetAll();
        //TEntity GetById(object id);
    }
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		eRezervacijaDbContext _dbContext;
		DbSet<TEntity> dbset;
		public Repository(eRezervacijaDbContext db)
		{
			_dbContext = db;
			dbset = _dbContext.Set<TEntity>();
		}

		public void Add(TEntity obj)
		{
			_dbContext.Add(obj);
			_dbContext.SaveChanges();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return dbset.AsEnumerable();
		}
        public void Remove(TEntity obj)
		{
			_dbContext.Remove(obj);
			_dbContext.SaveChanges();
		}
		
		public void Update(TEntity obj)
		{
			_dbContext.Entry(obj).State = EntityState.Modified;
			_dbContext.SaveChanges();
		}

        //public TEntity GetById(object id)
        //{
        //	return _dbContext.Set<TEntity>().Find(id);
        //}

	}
}
