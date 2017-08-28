using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeanAlexandre.Api.Controller
{
    [Route("api/[controller]")]
    public class ResumeController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        [Route("{userName}")]
        public async Task<IActionResult> Get(string userName)
        {
            return await Task.FromResult(Ok(userName));
        }
    }
}