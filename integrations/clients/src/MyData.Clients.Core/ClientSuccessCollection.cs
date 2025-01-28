using System;
using System.Linq;
using System.Collections.Generic;

namespace MyData.Clients;

public class ClientSuccessCollection<T> : ClientSuccess
{
    public ClientSuccessCollection(IEnumerable<T> data)
    {
        Data = data;
    }

    public int Count => Data.Count();

    public IEnumerable<T> Data { get; }
}
