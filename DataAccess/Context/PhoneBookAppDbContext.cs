using DataAccess.SeedData;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class PhoneBookAppDbContext : IdentityDbContext<User>
    {
        public PhoneBookAppDbContext(DbContextOptions<PhoneBookAppDbContext> options) :base(options)
        {
            
        }
        public DbSet<Contact> Contact { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactSeedData());
            modelBuilder.ApplyConfiguration(new UserSeedData());

            modelBuilder.Entity<Contact>().HasIndex(x=>x.PhoneNumber).IsUnique(true);
            base.OnModelCreating(modelBuilder);
        }
    }
}
