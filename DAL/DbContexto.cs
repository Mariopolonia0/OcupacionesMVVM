using Microsoft.EntityFrameworkCore;
using MVVMOcupaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMOcupaciones.DAL
{
    public class DbContexto : DbContext
    {
        public DbSet<Ocupacion> Ocupacions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging().UseSqlite(@"Data Source= DATA\BDOcupaciones.db");
        }

    }
}
