using BranchesApi.Models;
using BranchesApi.Requestes_Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BranchesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly TestContext _testContext;
        public BranchController(TestContext testContext)
        {
            _testContext = testContext;
        }
        [HttpPost("get_branches")]
        public async Task<IActionResult> getBranches()
        {
         
            return Ok();
        }
        [HttpPost("add_branch")]
        public async Task<IActionResult> addBranch(addBranchRequest add)
        {
            var addBranch = new Models.Branch
            {
                BranchName = add.name,
                BranchNameLatin = add.nameEn,
                Address=add.address,
                ContactName=add.contact
            };
            await _testContext.Branches.AddAsync(addBranch);
            await _testContext.SaveChangesAsync();
            return Ok();
        }
    }
}
