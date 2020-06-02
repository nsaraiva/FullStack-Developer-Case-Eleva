using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
	public interface IBaseService<T> where T : BaseEntity
	{
		T Post(T obj);

		T Put(T obj);

		void Delete(long id);

		T Get(long id);

		IList<T> Get();
	}
}
