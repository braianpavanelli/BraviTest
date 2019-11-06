using BraviBraian.Application.Interface;
using BraviBraian.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BraviBraian.Application
{
    public class AppBaseService<TEntity> : IDisposable, IAppBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> baseService;

        public AppBaseService(IBaseService<TEntity> _baseService)
        {
            baseService = _baseService;
        }

        public void Add(TEntity obj)
        {
            baseService.Add(obj);
        }

        public Task<bool> AddAsync(TEntity obj)
        {
            return baseService.AddAsync(obj);
        }

        public void Dispose()
        {
            baseService.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return baseService.GetAll();
        }

        public TEntity GetById(string id)
        {
            return baseService.GetById(id);
        }

        public TEntity GetById(int id)
        {
            return baseService.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            baseService.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            baseService.Update(obj);
        }
    }
}
