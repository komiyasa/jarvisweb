using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBasic.Models;

namespace MvcBasic.Data
{
    public class MvcBasicContext : DbContext
    {
        public MvcBasicContext (DbContextOptions<MvcBasicContext> options)
            : base(options)
        {
        }

        public DbSet<MvcBasic.Models.Member> Member { get; set; }
    }
}
