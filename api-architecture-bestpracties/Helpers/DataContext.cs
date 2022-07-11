using api_architecture_bestpracties.Models;
using Microsoft.EntityFrameworkCore;

namespace api_architecture_bestpracties.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
