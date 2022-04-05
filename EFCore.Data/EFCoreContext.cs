using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class EFCoreContext : DbContext
    {
        public DbSet<EFCore.Domain.EFCore> EFCores { get; set; }
        public DbSet<EFCore.Domain.Word> Words { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog=EFCoreDB";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
