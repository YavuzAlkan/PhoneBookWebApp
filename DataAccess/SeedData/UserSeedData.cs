using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData
{
    public class UserSeedData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();
            builder.HasData(
                new User
                {
                    Id = "bb90dc29-c9cd-49e5-9f45-532b3c066b87",
                    UserName = "Ahmet.Yılmaz",
                    Email = "ahmet.yilmaz@yba.com",
                    NormalizedUserName = "AHMET.YILMAZ",
                    NormalizedEmail = "AHMET.YILMAZ@YBA.COM",
                    PasswordHash = hasher.HashPassword(null, "123")
                },
                new User
                {
                    Id = "db2fa01f-4054-4439-84d1-58020cb7bfe1",
                    UserName = "Necdet.Dol",
                    Email = "necdet.dol@yba.com",
                    NormalizedUserName="NECDET.DOL",
                    NormalizedEmail="NECDET.DOL@YBA.COM",
                    PasswordHash=hasher.HashPassword(null,"1234")
                }



                );
        }
    }
}
