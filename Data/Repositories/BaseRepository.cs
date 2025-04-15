using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCartys.Data.Context;
using TestCartys.Domain.InterFaces.Repositories;

namespace TestCartys.Data.Repositories
{
    public class BaseRepository<Tentity> : IBaseRepository<Tentity> where Tentity : class
    {
        protected readonly MyContext _meuContexto;
        protected readonly DbSet<Tentity> _dbSet;
        public BaseRepository(MyContext myContext)
        {
            _meuContexto = myContext;
            _dbSet = _meuContexto.Set<Tentity>();
        }
        public async Task Add(Tentity entidade)
        {
            _dbSet.Add(entidade);

        }

        public async Task Delete(int Id)
        {
            var entity = await _dbSet.FindAsync(Id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task<Tentity> Get(int id)
        {
            try
            {
                var result = await _dbSet.FindAsync(id);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Tentity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Update(Tentity entidade)
        {
            _dbSet.Update(entidade);
        }
    }
}
