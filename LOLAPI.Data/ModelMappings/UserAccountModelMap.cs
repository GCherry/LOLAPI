using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LOLAPI.Shared.Entities;


namespace LOLAPI.Data.ModelMappings
{
    public class UserAccountModelMap : EntityTypeConfiguration<UserAccount>
    {
        public UserAccountModelMap()
        {
            this.Property(i => i.UserName).IsRequired().HasMaxLength(500);
            this.Property(i => i.Password).IsRequired();
            this.Property(i => i.Email).IsRequired().HasMaxLength(500);
            this.Property(i => i.Active).IsRequired();
            this.Property(i => i.PasswordHint).IsOptional();
        }
    }
}
