using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using webapi.data.Entities;

namespace webapi.data.Data
{
  public class DataContext : DbContext
  {
    private IConfiguration _config;
    public DataContext(DbContextOptions<DataContext> options, IConfiguration config) : base(options)
    {
      _config = config;
    }

    public DbSet<Applicant> Applicant { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
      optionsBuilder.EnableSensitiveDataLogging();
      optionsBuilder.UseSqlServer(_config.GetConnectionString("DbConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
  }
}