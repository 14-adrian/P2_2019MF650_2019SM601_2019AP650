using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace P2_2019MF650_2019SM601_2019AP650.Models
{
    public class reportesDBContext : DbContext
    {
        public reportesDBContext(DbContextOptions<reportesDBContext> options) : base(options)
        {

        }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<generos> generos { get; set; }
        public DbSet<casos_reportados> casos_reportados { get; set; }
    }
}
