using System;
using System.Net.Http;
using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Command;
using GeanAlexandre.Context.Domain.CommandHandler;
using GeanAlexandre.Context.Domain.Model;
using GeanAlexandre.Context.Domain.Query;
using GeanAlexandre.Context.Domain.QueryHandler;
using Microsoft.AspNetCore.Mvc;

namespace GeanAlexandre.Api.Controller
{
    [Route("api/[controller]")]
    public class ResumeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IGetUserQueryHandler _getUserQueryHandler;
        private readonly ICreateResumeCommandHandler _createResumeCommandHandler;

        public ResumeController(
            IGetUserQueryHandler getUserQueryHandler,
            ICreateResumeCommandHandler createResumeCommandHandler)
        {
            _getUserQueryHandler = getUserQueryHandler;
            _createResumeCommandHandler = createResumeCommandHandler;
        }

        [HttpGet]
        [Route("{userName}")]
        public async Task<IActionResult> Get(string userName)
        {
            try
            {
                return await _getUserQueryHandler.ExecuteAsync(GetUserQuery.CreateCommand(userName))
                    .ContinueWith(task => Ok(task.Result));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("seed")]
        public async Task<IActionResult> Seed()
        {
            try
            {
                return await _createResumeCommandHandler.ExecuteAsync(new CreateResumeCommand
                    {
                        UserName = "geanalexandre",
                        Resume = new Resume
                        {
                            ResumeLanguage = ResumeLanguage.En
                        }
                    })
                    .ContinueWith(task => Ok());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}