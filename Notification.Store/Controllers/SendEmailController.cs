using Microsoft.AspNetCore.Mvc;
using Notification.Store.Services.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Notification.Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendEmailController : ControllerBase
    {

        private readonly ISendEmailService _sendEmail;
        public SendEmailController(ISendEmailService sendEmail)
        {
            _sendEmail = sendEmail;
        }



        // POST api/<SendEmailController>
        [HttpPost]
        public void Post([FromBody] string email)
        {
            _sendEmail.SendEmailMessage();
        }

    
    }
}
