using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCartys.Data.Context;
using TestCartys.Data.Entities;
using TestCartys.Domain.InterFaces.Repositories;

namespace TestCartys.Data.Repositories
{
    public class UserRepository : BaseRepository<Users>,IRepositoryUser
    {
        public UserRepository(MyContext myContext) : base(myContext)
        {
        }

        public List<Users> BuscarPorNome(string nome)
        {
            return _dbSet
             .Where(u => u.Nome.Contains(nome))
             .OrderBy(u => u.Nome)
             .ToList();
        }
    }
}
