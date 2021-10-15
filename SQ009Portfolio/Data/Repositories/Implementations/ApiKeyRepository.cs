using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using SQ009Portfolio.Data.Dtos;
using SQ009Portfolio.Data.Models;
using SQ009Portfolio.Data.Repositories.Contracts;

namespace SQ009Portfolio.Data.Repositories.Implementations
{
    public class ApiKeyRepository : IApiKeyRepository
    {
        private readonly PortfolioContext _context;

        public ApiKeyRepository(PortfolioContext context)
        {
            _context = context;
        }

        public async Task<ApiKey> GetApiKey(string apiKey)
        {
            return await _context.APIKeys.FirstOrDefaultAsync(x => x.Key == apiKey);
        }

        public async Task<IEnumerable<ApiKeyToReturnDto>> GetApiKeys()
        {
            return await _context.APIKeys
                        .Include(x => x.AppUser)
                        .Select(x => new ApiKeyToReturnDto
                        {
                            Name = $"{x.AppUser.FirstName} {x.AppUser.LastName}",
                            ApiKey = x.Key.ToString()
                        }).ToListAsync();
        }
    }
}
