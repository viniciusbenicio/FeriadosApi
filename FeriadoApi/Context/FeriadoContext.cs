using FeriadoApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FeriadoApi.Context
{
    public class FeriadoContext : DbContext
    {
        public FeriadoContext(DbContextOptions<FeriadoContext> options) : base(options) { }

        public DbSet<Feriado> Feriados { get; set; }

    }
}
