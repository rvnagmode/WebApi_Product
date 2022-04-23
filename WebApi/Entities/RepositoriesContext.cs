using System;
using WebApi.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApi.Entities
{
    public class RepositoriesContext:DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
