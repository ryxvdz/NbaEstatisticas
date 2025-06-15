using Microsoft.EntityFrameworkCore;
using MeuBackend.Models;

namespace MeuBackend.Data;

public class AppDbContext : DbContext
{

    //chamando as tabelas do banco de dados
    public DbSet<Ginasios> Ginasios { get; set; }
    public DbSet<Jogadores> Jogadores { get; set; }
    public DbSet<Jogos> Jogos { get; set; }
    public DbSet<Times> Times { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    
}
