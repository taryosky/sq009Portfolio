using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using SQ009Portfolio.Data.Models;
using SQ009Portfolio.Data.Repositories.Contracts;

namespace SQ009Portfolio.Data.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly PortfolioContext _ctx;

        public UserRepository(PortfolioContext ctx)
        {
            _ctx = ctx;
        }

        public AppUser GetUserById(int userId) =>
            _ctx.Users.Include(x => x.WorkHistory)
            .Include(x => x.EducationHistory)
            .Include(x => x.Messages)
            .FirstOrDefault(x => x.Id == userId);
    }
}
