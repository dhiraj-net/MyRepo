using Microsoft.AspNetCore.Mvc;

namespace HelloApi.Controllers
{
    [Route("/")]
    //[ApiController]
    public class WelcomeController:ControllerBase
    {      
        public WelcomeMessage _message;
        public WelcomeController(WelcomeMessage message)
        {
            this._message=message;
        }
        [HttpGet]
        public string SayHello()=>_message.Message;
    }
    
}