using JsonApiSerilogBootstrapLoggerRepro.Model;
using Microsoft.EntityFrameworkCore;

namespace JsonApiSerilogBootstrapLoggerRepro
{
    public class MyDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }
}
