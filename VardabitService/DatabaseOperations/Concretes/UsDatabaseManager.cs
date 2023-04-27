﻿using ConsoleApp1.DatabaseOperations.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VardabitService.DatabaseOperations.Context;

namespace ConsoleApp1.DatabaseOperations.Concretes
{
    public class UsDatabaseManager<T> : IUsDatabaseService<T> where T : class
    {
        protected readonly UsDatabaseContext _context;

        public UsDatabaseManager(UsDatabaseContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
