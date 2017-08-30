using System;
using System.Net.Http;
using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Query;
using GeanAlexandre.Context.Domain.QueryHandler;
using Microsoft.AspNetCore.Mvc;

namespace GeanAlexandre.Api.Controller
{
    [Route("api/[controller]")]
    public class ResumeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IGetResumeQueryHandler _getResumeQueryHandler;

        public ResumeController(IGetResumeQueryHandler getResumeQueryHandler)
        {
            _getResumeQueryHandler = getResumeQueryHandler;
        }

        [HttpGet]
        [Route("{userName}")]
        public async Task<IActionResult> Get(string userName)
        {
            try
            {
                return await _getResumeQueryHandler.Execute(GetResumeQuery.CreateCommand(userName))
                    .ContinueWith(task => Ok());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}