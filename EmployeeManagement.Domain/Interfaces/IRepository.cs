﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
    }
}
