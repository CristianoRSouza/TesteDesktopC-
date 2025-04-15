using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCartys.Data.Context;
using TestCartys.Domain.InterFaces.Repositories;

namespace TestCartys.Data.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        public IRepositoryUser RepositoryUser {  get;}
        private readonly MyContext _context;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(IRepositoryUser repositoryUser, MyContext context)
        {
            RepositoryUser = repositoryUser;
            _context = context;
        }


        public async Task BeginTransactionAsync()
        {
            if (_transaction == null)
            {
                _transaction = await _context.Database.BeginTransactionAsync();
            }
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public async Task RollbackAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }
    }
}
