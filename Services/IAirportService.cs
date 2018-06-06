using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public interface IAirportService
    {
        Task<int> DataUpdataAsync();
        Task<IEnumerable<Airport>> AllAsync();
        Task<IEnumerable<Airport>> ListAsync(int pageSize, int pageIndex = 1, string sort = null, string filter = null);
        Task<IEnumerable<Airport>> SelectAsync(Expression<Func<Airport, bool>> predicate);
        Task<Airport> SelectFirstAsync(Expression<Func<Airport, bool>> predicate);
        Task<int> UpdataAsync(params Airport[] airports);
        Task<int> AddAsync(params Airport[] airports);
        Task<int> RemoveAsync(params Airport[] airports);
    }
}