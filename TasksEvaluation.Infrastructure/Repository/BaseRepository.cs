﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksEvaluation.Core.Interfaces.IRepositories;
using TasksEvaluation.Infrastructure.Data;

namespace TasksEvaluation.Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;
        protected DbSet<T> DbSet => _dbContext.Set<T>();

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> Create(T model)
        {
            await DbSet.AddAsync(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task Delete(T model)
        {
            DbSet.Remove(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById<IdType>(IdType id)
        {
            var data = await DbSet.FindAsync(id);
            if (data is null)
            {
                throw new Exception("No data Found");
            }
            return data;
        }

        public async Task SaveChangeAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(T model)
        {
            DbSet.Update(model);
            await _dbContext.SaveChangesAsync();
        }
    }
}
