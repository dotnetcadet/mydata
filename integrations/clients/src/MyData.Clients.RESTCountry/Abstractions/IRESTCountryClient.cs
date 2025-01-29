using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyData.Clients.RESTCountry;

public interface IRESTCountryClient : IClient
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Either<ClientSuccessCollection<RESTCountry>, ClientError>> GetAllCountriesAsync(
        CancellationToken cancellationToken = default);

}
