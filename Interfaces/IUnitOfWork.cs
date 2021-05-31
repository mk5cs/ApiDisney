using System;
using System.Threading.Tasks;
using ApiDisney.Models;


namespace Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
         IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
         Task<int> Complete();
    }
}