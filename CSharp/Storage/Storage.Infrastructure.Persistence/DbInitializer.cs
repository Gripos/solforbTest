using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Infrastructure.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(StorageDBContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
