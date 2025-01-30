using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MyData.Databases;


public interface IIncludableRepository<T> : IQueryable<T>, IRepository
    where T : Entity, new()
{
    IIncludableRepository<T, TProperty> Include<TProperty>(
        Expression<Func<T, IEnumerable<TProperty>>> navigation)
        where TProperty : Entity, new();
}

public interface IIncludableRepository<T, TProperty> : IIncludableRepository<T>
    where TProperty : Entity, new()
    where T : Entity, new()
{
    IIncludableRepository<TProperty, TNested> ThenInclude<TNested>(
        Expression<Func<TProperty, IEnumerable<TNested>>> navigation) 
        where TNested : Entity, new();
}