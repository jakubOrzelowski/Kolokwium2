using Microsoft.EntityFrameworkCore;
using Kolokwium2.Models;

namespace Kolokwium2.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Titles> Titles { get; set; }
    public DbSet<Items> Items { get; set; }
    public DbSet<Characters> Characters { get; set; }
    public DbSet<Backpacks> Backpacks { get; set; }
    public DbSet<CharacterTitles> CharacterTitles { get; set; }

    
}