using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData;

public class CollectionResponse<T> where T : Entity
{
    public ResponseMeta? Meta { get; set; }
    public IEnumerable<T>? Data { get; set; }
}
