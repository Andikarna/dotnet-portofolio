
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Dapper;
using System.Transactions;
using System.Data;
using AdidataDbContext.Models.MySql.Auth;
using AdidataDbContext.Models.MySql.Hrm;
using System.Globalization;
using AdidataDbContext.Models.MySql.Recruitment;

namespace BasicProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BasicController : ControllerBase
    {
        private readonly RecruitmentContext _recruitmentContext;

        public BasicController(RecruitmentContext recruitmentContext)
        {
            _recruitmentContext = recruitmentContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _recruitmentContext.CrudTables.ToListAsync();
            var responseObject = new {
                status = HttpStatusCode.OK,
                message = "Success",
                data = data
            };

            return Ok(responseObject);
        }
        

    }
}


