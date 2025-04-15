using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCartys.Domain.InterFaces.Repositories
{
    public interface IBaseRepository<Tentity>
    {
        Task<Tentity> Get(int id);
        Task<IEnumerable<Tentity>> GetAll();
        Task Add(Tentity entidade);
        Task Delete(int Id);
        Task Update(Tentity entidade);
    }
}
