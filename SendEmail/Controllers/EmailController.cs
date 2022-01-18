namespace SendEmail.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SendEmail.Model;
    using SendEmail.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class EmailController: ControllerBase
    {
        private readonly IEmailServices _emailServices;

        public EmailController(IEmailServices emailServices)
        {
            _emailServices = emailServices;
        }

        [HttpPost("SendMail")]
        public async Task<IActionResult> SendMail([FromForm] EmailReq emailReq)
        {
            try
            {
                await _emailServices.SendEmailAsync(emailReq);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
