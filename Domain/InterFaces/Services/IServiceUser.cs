using FluentValidation.Results;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCartys.Data.Entities;

namespace TestCartys.Domain.InterFaces.Services
{
    public interface IServiceUser
    {
        public Task<ValidationResult> CreateUser(Users user);

        public List<Users> BuscarPorNome(string nome);
    }
}
