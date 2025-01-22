using Core.Entities.AccountManagement;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<UserAccounts> tblUserAccounts { get; set; }
    }
}
