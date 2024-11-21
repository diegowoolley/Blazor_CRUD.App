using BlazorCRUD.App.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blazor_CRUD.App.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Produtos> produtos { get; set; }
    }
}
