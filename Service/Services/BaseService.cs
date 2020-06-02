using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Service.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public T Post(T obj)
        {
            _baseRepository.Insert(obj);
            return obj;
        }

        public T Put(T obj)
        {
            _baseRepository.Update(obj);
            return obj;
        }

        public void Delete(long id)
        {
            if (id == 0)
                throw new ArgumentException("O id não pode ser 0.");

            _baseRepository.Delete(id);
        }

        public IList<T> Get() => _baseRepository.SelectAll();

        public T Get(long id)
        {
            if (id == 0)
                throw new ArgumentException("O id não pode ser 0.");

            return _baseRepository.Select(id);
        }
    }
}
