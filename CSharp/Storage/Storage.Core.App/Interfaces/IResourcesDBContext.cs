using Microsoft.EntityFrameworkCore;
using Storage.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Core.App.Interfaces
{
    public interface IResourcesDBContext
    {
        DbSet<Resource> resources { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
