using Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GenericRepository
{
    public abstract class RepoBase<TContext, T> : IRepoBase<T> where T : class where TContext : DbContext
    {
        protected TContext _context;

        public RepoBase(TContext context) => this._context = context;

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
                _context.Set<T>()
                .AsNoTracking() :
                _context.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges) =>
            !trackChanges ?
                _context.Set<T>()
                .Where(expression)
                .AsNoTracking() :
                _context.Set<T>()
                .Where(expression);
    }
}
