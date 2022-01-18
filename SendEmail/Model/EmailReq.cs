namespace SendEmail.Model
{
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;

    public class EmailReq
    {
        public string Email { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public List<IFormFile> Attachments { get; set; }
    }
}
