using System;
using System.Collections.Generic;
using System.Linq;

namespace MyData.Databases;

public interface IQueryableRepository<T> : IRepository<T>, IQueryable<T>
    where T : Entity<T>, new()
{

}
