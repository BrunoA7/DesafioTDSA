using ClienteCrud.web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClienteCrud.web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }


        public DbSet<Cliente> Clientes { get; set; }

    }
}
