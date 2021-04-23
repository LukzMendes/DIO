using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.api.Business.Entiti;

namespace web.api.Infra.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("TB_User");
            builder.HasKey(p => p.Id);
            builder.Property(p =>p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Descricao);
            builder.Property(p => p.CodigoUser);
            builder.Property(p => p.GetUser());




        }
    }
}
