using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SQ009Portfolio.Data.Dtos;
using SQ009Portfolio.Data.Models;

namespace SQ009Portfolio.Data.Repositories.Contracts
{
    public interface IApiKeyRepository
    {
        Task<IEnumerable<ApiKeyToReturnDto>> GetApiKeys();
        Task<ApiKey> GetApiKey(string apiKey);
    }
}
