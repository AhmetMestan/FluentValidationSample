using Microsoft.EntityFrameworkCore;

namespace FluentValidationSample.Models.ORM
{
    public class AkademiİstanbulContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-D2UVJQ0; Database = Akademiİstanbul; Trusted_connection=True;TrustServerCertificate=true");
        }
        public DbSet<Student> Students { get; set; }
    }
}
