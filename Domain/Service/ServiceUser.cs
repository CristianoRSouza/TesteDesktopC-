using FluentValidation;
using FluentValidation.Results;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCartys.Data.Entities;
using TestCartys.Domain.InterFaces.Repositories;
using TestCartys.Domain.InterFaces.Services;

namespace TestCartys.Domain.Service
{
    public class ServiceUser : IServiceUser
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<Users> _validator;

        public ServiceUser(IUnitOfWork unitOfWork, IValidator<Users> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public List<Users> BuscarPorNome(string nome)
        {
            return _unitOfWork.RepositoryUser.BuscarPorNome(nome);
        }

        public async Task<ValidationResult> CreateUser(Users user)
        {
            var validationResult = await _validator.ValidateAsync(user);
            if (!validationResult.IsValid)
                return validationResult;

            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _unitOfWork.RepositoryUser.Add(user);
                await _unitOfWork.CommitAsync();
            }
            catch
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }

            return validationResult;
        }
    }

}
