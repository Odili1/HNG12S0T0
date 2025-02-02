using Microsoft.AspNetCore.Mvc;

namespace HNG12S0T0.Controllers
{
    [ApiController]
    [Route("/")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var response = new
            {
                email = "ezedigwegerald1@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("yyy-MM-ddTHH:mm:ssZ"),
                github_url = "https://github.com/Odili1/HNG12S0T0"
            };

            return Ok(response);
        }
    }
}