using MyData.Clients.RESTCountry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Clients.RESTCountry;

public interface IRESTCountryClient : IClient
{

    Task<RESTCountryClientResponse<IEnumerable<Country>>> GetAllCountriesAsync(CancellationToken cancellationToken = default);
}
