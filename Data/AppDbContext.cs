using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;

//Esta es la clase que conecta con la base de datos.
namespace LibrarySystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        {
        }
    }
}