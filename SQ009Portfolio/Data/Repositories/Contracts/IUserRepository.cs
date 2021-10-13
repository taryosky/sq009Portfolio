using System;

using SQ009Portfolio.Data.Models;

namespace SQ009Portfolio.Data.Repositories.Contracts
{
    public interface IUserRepository
    {
        public AppUser GetUserById(int userId);
    }
}
