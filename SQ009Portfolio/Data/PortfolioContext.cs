using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using SQ009Portfolio.Data.Models;

namespace SQ009Portfolio.Data
{
    public class PortfolioContext: DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options): base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<WorkHistory> WorkHistories { get; set; }
        public DbSet<EducationHistory> EducationHistories { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ApiKey> APIKeys { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
