using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Examination.Domain.Exceptions;

namespace Examination.Domain.SeedWork
{
    public interface IRepositoryBase<T> where T : IAggregateRoot
    {
        Task InsertAsync(T obj);

        Task UpdateAsync(T obj);

        Task DeleteAsync(string id);

        void StartTransaction();

        Task CommitTransactionAsync(T entity, CancellationToken cancellationToken = default);

        Task AbortTransactionAsync(CancellationToken cancellationToken = default);
    }
}