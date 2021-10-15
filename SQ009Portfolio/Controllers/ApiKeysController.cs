using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SQ009Portfolio.Data.Dtos;
using SQ009Portfolio.Data.Repositories.Contracts;
using SQ009Portfolio.Data.Response;

namespace SQ009Portfolio.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ApiKeysController : ControllerBase
    {
        private readonly IRepositoryManager _repo;

        public ApiKeysController(IRepositoryManager repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ResponseModel<ApiKeyToReturnDto>>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetApiKeys([FromHeader]string token)
        {
            if(token != "RansoEneni")
            {
                var error = new Dictionary<string, string>
                {
                    ["token"] = "Invalid token"
                };
                return Unauthorized(ApiResponse.CreateResponse<string>("Unauthorized", error, null));
            }

            var apiKeys = await _repo.ApiKeyRepo.GetApiKeys();
            return Ok(ApiResponse.CreateResponse("ApiKeys", null, apiKeys));
        }
    }
}
