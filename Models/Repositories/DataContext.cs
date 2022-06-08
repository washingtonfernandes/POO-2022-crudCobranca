using Aula11CrudClient.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace Aula11CrudClient.Models.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
            :base(opts)
        {}

        public DbSet<Client> Client { get; set; }

        public DbSet<Debit> Debit { get; set; }
    }
}