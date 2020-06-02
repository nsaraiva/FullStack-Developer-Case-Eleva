using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Data.Repositories
{
	public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
	{
		private readonly SqlServerContext _context;

		public BaseRepository(SqlServerContext context)
		{
			_context = context;
		}

		public void Insert(T obj)
		{
			_context.Set<T>().Add(obj);
			_context.SaveChanges();
		}

		public void Update(T obj)
		{
			_context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			_context.SaveChanges();
		}

		public void Delete(long id)
		{
			_context.Set<T>().Remove(Select(id));
			_context.SaveChanges();
		}

		public IList<T> SelectAll()
		{
			return _context.Set<T>().ToList();
		}

		public T Select(long id)
		{
			return _context.Set<T>().Find(id);
		}
	}
}
