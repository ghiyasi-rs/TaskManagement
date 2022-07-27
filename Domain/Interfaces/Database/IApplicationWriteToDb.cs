using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Database
{
    public interface IApplicationWriteToDb : IApplicationReadFromDb
    {
        Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default);
    }
}
