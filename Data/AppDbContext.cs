using Microsoft.EntityFrameworkCore;

namespace BlazorElectronDemo.Data;

public class AppDbContext : DbContext
{
    public DbSet<Item> Items { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}