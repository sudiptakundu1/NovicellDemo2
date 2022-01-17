﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Contracts
{
    public interface IRepoBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges);
    }
}
