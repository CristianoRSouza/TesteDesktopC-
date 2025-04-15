using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCartys.Data.Entities;

namespace TestCartys.Domain.InterFaces.Repositories
{
    public interface IRepositoryUser:IBaseRepository<Users>
    {
        public List<Users> BuscarPorNome(string nome);

    }
}
