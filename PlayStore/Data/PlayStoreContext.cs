using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PlayStore.Models
{
    public class PlayStoreContext : DbContext
    {
        public PlayStoreContext (DbContextOptions<PlayStoreContext> options)
            : base(options)
        {
        }

        public DbSet<PlayStore.Models.Rating> Rating { get; set; }
    }
}
