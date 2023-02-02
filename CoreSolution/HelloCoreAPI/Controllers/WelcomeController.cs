using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        private readonly WelcomeMessage _message;
        public WelcomeController(WelcomeMessage message)
        {
            _message = message;
        }

        [HttpGet]
        public string SayHello()
        {
            return _message.Message;
        }
    }
}

