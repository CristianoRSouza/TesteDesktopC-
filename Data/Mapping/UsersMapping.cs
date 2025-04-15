using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCartys.Data.Entities;

namespace TestCartys.Data.Mapping
{
    public class UsersMapping : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
           
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.Idade)
                   .IsRequired();

            builder.Property(u => u.Ativo)
                   .IsRequired();

            builder.Property(u => u.DataNascimento)
                   .IsRequired();

            builder.HasIndex(u => u.Email).IsUnique(); 
        }
    }
}
