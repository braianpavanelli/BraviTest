﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace BraviBraian.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        Task<bool> AddAsync(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
        TEntity GetById(string id);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
