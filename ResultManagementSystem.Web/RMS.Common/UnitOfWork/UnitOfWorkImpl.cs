using RMS.Common.Repository.Implementation;
using RMS.Common.Repository.Interface;
using RMS.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Common.UnitOfWork
{
    public class UnitOfWorkImpl : IUnitOfWork
    {
        private static AppDbContext Context { get; set; }
        public UnitOfWorkImpl(AppDbContext context)
        {
            Context = context;
        }
        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new IRepositoryImpl<TEntity>(Context);
        }
    }
}
