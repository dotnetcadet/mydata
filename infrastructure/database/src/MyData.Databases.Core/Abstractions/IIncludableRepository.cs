using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MyData.Databases;


public interface IIncludableRepository<T> : IQueryable<T>, IRepository
    where T : class, new()
{
    IIncludableRepository<T, TProperty> Include<TProperty>(
        Expression<Func<T, IEnumerable<TProperty>>> navigation)
        where TProperty : class, new();
}

public interface IIncludableRepository<T, TProperty> : IIncludableRepository<T>
    where TProperty : class, new()
    where T : class, new()
{
    IIncludableRepository<TProperty, TNested> ThenInclude<TNested>(
        Expression<Func<TProperty, IEnumerable<TNested>>> navigation) 
        where TNested : class, new();
}