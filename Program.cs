using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestCartys.Data.Context;
using TestCartys.Data.Entities;
using TestCartys.Data.Repositories;
using TestCartys.Domain.InterFaces.Repositories;
using TestCartys.Domain.InterFaces.Services;
using TestCartys.Domain.Service;
using TestCartys.Domain.Validations;

namespace TestCartys
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            ApplicationConfiguration.Initialize();

            var form = host.Services.GetRequiredService<Cadastro>();
            Application.Run(form);
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Injeção do DbContext
                    services.AddDbContext<MyContext>(options =>
                        options.UseSqlServer("Server=localhost;Database=BancoCartys;Trusted_Connection=True;TrustServerCertificate=True;"));

                    services.AddScoped<Cadastro>();
                    services.AddScoped<IValidator<Users>, UserValidator>();
                    services.AddScoped<IServiceUser, ServiceUser>();
                    services.AddScoped<IRepositoryUser, UserRepository>();
                    services.AddScoped<IUnitOfWork, UnitOfWork>();
                    services.AddScoped<ServiceUser>();

                });
        }
    }
}
