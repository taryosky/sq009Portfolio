using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SQ009Portfolio.Data.Repositories.Contracts;

namespace SQ009Portfolio.Data.Repositories.Implementations
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly PortfolioContext _ctx;
        private IUserRepository _userRepository;

        public RepositoryManager(PortfolioContext ctx)
        {
            _ctx = ctx;
        }

        public IUserRepository UserRepo
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_ctx);
                return _userRepository;
            }
        }
    }
}
