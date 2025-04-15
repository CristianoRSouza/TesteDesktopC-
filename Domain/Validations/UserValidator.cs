using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCartys.Data.Entities;

namespace TestCartys.Domain.Validations
{
    public class UserValidator : AbstractValidator<Users>
    {
        public UserValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório")
                .MinimumLength(2).WithMessage("O nome deve ter pelo menos 2 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O e-mail é obrigatório")
                .EmailAddress().WithMessage("O e-mail não é válido");

            RuleFor(x => x.Idade)
                .InclusiveBetween(0, 120).WithMessage("A idade deve estar entre 0 e 120");

            RuleFor(x => x.DataNascimento)
                .LessThan(DateTime.Now).WithMessage("A data de nascimento deve ser no passado");

            RuleFor(x => x.Ativo)
                .NotNull().WithMessage("Informe se o usuário está ativo");
        }
    }
}
