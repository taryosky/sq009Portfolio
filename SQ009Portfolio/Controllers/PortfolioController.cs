using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SQ009Portfolio.Data.Dtos;
using SQ009Portfolio.Data.Models;
using SQ009Portfolio.Data.Repositories.Contracts;
using SQ009Portfolio.Data.Response;

namespace SQ009Portfolio.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public PortfolioController(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser([FromHeader]string apiKey)
        {
            var key = await _repositoryManager.ApiKeyRepo.GetApiKey(apiKey);
            if(key == null)
            {
                var error = new Dictionary<string, string>
                {
                    ["user"] = "User not Authorized"
                };
                return Unauthorized(ApiResponse.CreateResponse<string>("Unauthorized", error, null));
            }

            var user = _repositoryManager.UserRepo.GetUserById(key.AppUserId);
            if(user == null)
            {
                var error = new Dictionary<string, string>
                {
                    ["user"] = "User not found"
                };
                return NotFound(ApiResponse.CreateResponse<string>("Not Found", error, null));
            }
            var userToReturn = _mapper.Map<UserToReturnDto>(user);
            return Ok(ApiResponse.CreateResponse<UserToReturnDto>("user", null, userToReturn));
        }
    }
}
