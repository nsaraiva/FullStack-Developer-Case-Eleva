﻿using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(long id);

        T Select(long id);

        IList<T> SelectAll();
    }
}
