using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SQ009Portfolio.Data.Repositories.Contracts;

namespace SQ009Portfolio.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public PortfolioController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpGet]
        public IActionResult GetUser(int Id) => Ok(_repositoryManager.UserRepo.GetUserById(Id));
    }
}
