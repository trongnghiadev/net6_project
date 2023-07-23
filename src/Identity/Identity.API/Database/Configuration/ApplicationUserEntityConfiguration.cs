using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Identity.API.Database.Configuration
{

  public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>

  {
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
      builder.Property(x => x.FistName).IsRequired().HasMaxLength(50);
       builder.Property(x => x.LatName).IsRequired().HasMaxLength(50);
    }
  }
}