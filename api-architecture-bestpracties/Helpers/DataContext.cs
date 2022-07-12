using api_architecture_bestpracties.Enuns;
using api_architecture_bestpracties.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace api_architecture_bestpracties.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<UserModel>()
                .Property(e => e.TypeUser)
                .HasConversion(
                v => v.ToString(),
                v => (TypeUser)Enum.Parse(typeof(TypeUser), v));
        }


        public DbSet<UserModel> Users { get; set; }

    }
}
