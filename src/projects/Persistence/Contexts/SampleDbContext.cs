using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain.Entities;
using Persistence.Mapping;

namespace Persistence.Contexts
{
    public class SampleDbContext : DbContext
    {
        public DbSet<SampleBaseEntity> SampleEntities { get; set; }
        public SampleDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SampleBaseEntityMapping());            
        }
    }
}
