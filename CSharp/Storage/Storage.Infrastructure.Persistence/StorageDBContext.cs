using Microsoft.EntityFrameworkCore;
using Storage.Core.App.Interfaces;
using Storage.Core.Domain;
using Storage.Infrastructure.Persistence.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Infrastructure.Persistence
{
    public class StorageDBContext: DbContext, IResourcesDBContext
    {
        public DbSet<Resource> Resources { get; set; }

        public StorageDBContext(DbContextOptions<StorageDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ResourseConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
